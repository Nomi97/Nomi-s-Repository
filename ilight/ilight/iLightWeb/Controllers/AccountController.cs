using ilight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevOne.Security.Cryptography.BCrypt;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Data.Entity;
namespace ilight.Controllers
{
    public class AccountController : Controller
    {
        private Context db = new Context();


        //Retrives the login View.
        public ActionResult Login()
        {
            return View();

        }
        //Checks the user input data against the stored crediantials in the database.  
        //If user input & stored data match create session that allows the user to access restricted pages that requires the user to be logged in.
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Login(Users users)
        {
            try
            {
                var exist = db.Users.Where(x => x.Email == users.Email).Where(z => z.Active == 1).ToList();

                if (exist != null)
                {


                    string salt = exist.Select(x => x.Salt).First().ToString();
                    string hashedpassword = exist.Select(x => x.Password).First().ToString();
                    string UserPassword = BCryptHelper.HashPassword(users.Password, salt);

                    if (UserPassword == hashedpassword)
                    {

                        Session.Add("loggedin", 1);
                        TempData["Message"] = "Login Success!";
                        TempData["Type"] = "Success";

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {

                        TempData["Message"] = "Login Failed! Wrong Username or Password.";
                        TempData["Type"] = "Danger";
                        return View();
                    }





                }
            }
            catch
            {
                TempData["Type"] = "Danger";
                TempData["Message"] = "Your account is not activated yet! Check your inbox.";
                return View();
            }
            return View();
        }
        //Sends different mails to the user depending on what tempData["Action"] Case is. 
        public async Task<ActionResult> Email(Emailmodel model)
        {

            var message = new MailMessage();
            message.To.Add(new MailAddress(TempData["Email"].ToString()));
            message.From = new MailAddress("noreply@workflare.se");


            message.IsBodyHtml = true;
            var body = "";
            switch (TempData["Action"].ToString())
            {
                //Sends a account confirmation link to the user in order to make their account "Active".
                case "Register":
                    body = "<h2>Welcome!</h2> <h3>Please Confirm your account in order to login!</h3> <a href='{0}'>Click here to confirm!</a><p> Regards I,Light</p>";
                    message.Body = string.Format(body, "fww.se/account/VerifyAccount/?query=" + TempData["verifyCode"].ToString());
                    message.Subject = "I,Light|Confirm your account!";
                    using (var smtp = new SmtpClient())
                    {
                        var credentials = new NetworkCredential
                        {
                            UserName = "noreply@workflare.se",
                            Password = "e[/x!MqJ2{av"
                        };
                        smtp.Credentials = credentials;
                        smtp.Host = "smtp.fsdata.se";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;

                        await smtp.SendMailAsync(message);
                        TempData["Type"] = "Success";
                        TempData["Message"] = "Registration succeded! Please check your mail inbox for a confirmation link!";
                        return RedirectToAction("login", "Account");

                    }

                    break;
                //Sends a Reset password link to the user in order to being enable to reset their password.

                case "resetPassword":
                    body = "<h2>A request to reset your password!</h2> <h3>Please click on the following link in order to reset your password!</h3> <a href='{0}'>Click here to reset!</a><p> Regards I,Light</p>";
                    message.Body = string.Format(body, "fww.se/account/verifyReset/?query=" + TempData["resetCode"].ToString());
                    message.Subject = "I,Light|Reset your password!";
                    using (var smtp = new SmtpClient())
                    {
                        var credentials = new NetworkCredential
                        {
                            UserName = "noreply@workflare.se",
                            Password = "e[/x!MqJ2{av"
                        };
                        smtp.Credentials = credentials;
                        smtp.Host = "smtp.fsdata.se";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;

                        await smtp.SendMailAsync(message);
                        TempData["Type"] = "Success";
                        TempData["Message"] = "Reset password successfully! An email has been sent to your inbox. ";
                        return RedirectToAction("login", "Account");

                    }
                    break;
            }
            return View();
        }
        //Retrieves the Register view.
        public ActionResult Register()
        {
            return View();
        }
        //Retrieves the inputs from Register view and Hashes the password and generates a salt. Then adds it to the database and redirect to the email Action for sending the Confirm account link.
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Register(Users users)
        {

            try
            {
                string password = users.Password;
                string salt = BCryptHelper.GenerateSalt(7);
                string hashedPassword = BCryptHelper.HashPassword(password, salt);
                string verifyCode = BCryptHelper.GenerateSalt(5);
                users.Password = hashedPassword;
                users.Salt = salt;
                users.Active = 0;
                users.verifyCode = verifyCode;
                db.Users.Add(users);
                db.SaveChanges();

                TempData["Email"] = users.Email;
                TempData["verifyCode"] = users.verifyCode;
                TempData["Action"] = "Register";
                return RedirectToAction("Email", "Account");

            }
            catch
            {
                TempData["Type"] = "Danger";
                TempData["Message"] = "Registration failed! Email already in use!";
                return View();
            }

        }
        // This action is used for verifying that the inputed verifycode matches the stored one in database and changes the matching users "Active" Column to 1.
        public ActionResult VerifyAccount(string Code, Users users)
        {
            try
            {
                string Original = Request.Url.Query.Substring(7);
                Code = Request.Url.Query.Substring(7, 29);
                var checkCode = db.Users.Where(x => x.verifyCode == Code).Single();

                if (checkCode != null)
                {
                    checkCode.Active = 1;
                    db.Entry(checkCode).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Type"] = "Success";
                    TempData["Message"] = "Your account is activated!";
                    return RedirectToAction("Login", "Account");
                }
            }
            catch
            {
                TempData["Type"] = "Danger";
                TempData["Message"] = "An error ocurred while confirming your account! Please try again.";
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        //Logout is used to destroy the current Session.
        public ActionResult Logout()
        {
            HttpContext.Session.Abandon();
            HttpContext.Session.Clear();
            HttpContext.Session.RemoveAll();
            TempData["Type"] = "Warning";
            TempData["Message"] = "You have been signed out!";
            return RedirectToAction("Login", "Account");
        }
        //Retrieves Reset password View.
        public ActionResult resetPassword()
        {
            return View();
        }
        //This function generates a reset hash and checks if the email exist in the database and if true it inserts the reset code into the users field "resetCode".
        //Then it sends the reset Code url as an email to the user. 
        //If no user exist with the provided email-address the function returns a error message. 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult resetPassword(string email, Users users)
        {
            try
            {

                string resetCode = BCryptHelper.GenerateSalt(5);
                var exist = db.Users.Where(x => x.Email == email.ToLower()).Single();

                if (exist != null)
                {
                    exist.resetCode = resetCode;
                    db.Entry(exist).State = EntityState.Modified;
                    db.SaveChanges();
                    TempData["Email"] = email;
                    TempData["resetCode"] = resetCode;
                    TempData["Action"] = "resetPassword";
                    return RedirectToAction("Email", "Account");


                }
                return View();
            }
            catch
            {
                TempData["Type"] = "Danger";
                TempData["Message"] = "The email supplied doesn´t exist in our system. ";
                return View();
            }
        }
        // After the user has clicked on the Reset Password link in the email it checks if the resetCode given in the url matches a users resetCode.
        // If true it returns a view where the user can input a new password and then sends the new password to public ActionResult verifyReset(string Code, Users users) .
        //Else if false return error message and send the user to Reset Password action again.
        public ActionResult verifyReset(string Code)
        {
            try
            {
                string Orginal = Request.Url.Query.Substring(7);
                Code = Request.Url.Query.Substring(7, 29);
                var resetCode = db.Users.Where(x => x.resetCode == Code).Single();
                if (resetCode != null)
                {
                    TempData["Type"] = "Success";
                    TempData["Message"] = "Enter your new password in the textbox below:";
                    TempData["resetCode"] = Code;
                    return View();
                }
            }
            catch
            {
                TempData["Type"] = "Danger";
                TempData["Message"] = "An error ocurred! Please check the url!";
                return RedirectToAction("resetpassword", "Account");
            }
            return View();
        }
        // After the User has inputed the new password for the account and pressed the submit button it sends the data here.
        // This function hashes the new password and generates a new salt to combine the hash with.
        // Finally the function inserts the new Hash and Salt into the database.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult verifyReset(string Code, Users users)
        {
            try
            {
                Code = TempData["resetCode"].ToString();
                var UserReset = db.Users.Where(x => x.resetCode == Code).Single();
                string salt = BCryptHelper.GenerateSalt(7);
                string hashedPassword = BCryptHelper.HashPassword(users.Password, salt);
                UserReset.Salt = salt;
                UserReset.Password = hashedPassword;
                UserReset.resetCode = null;
                db.Entry(UserReset).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Type"] = "Success";
                TempData["Message"] = "Your password was successfully changed! Please login with your new password.";
                return RedirectToAction("login");
            }
            catch
            {
                TempData["Type"] = "Danger";
                TempData["Message"] = "An error ocurred! Please try to enter your new password again!";
                return View();
            }

        }
    }
}