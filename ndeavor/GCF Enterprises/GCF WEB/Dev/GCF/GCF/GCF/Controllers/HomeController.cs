using GCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;

namespace GCF.Controllers
{
    public class HomeController : Controller
    {
        DatabaseContext dbCtx = new DatabaseContext();
        public ActionResult Index()
        {

            ViewBag.MembersModel = dbCtx.Members;
            return View();
        }
        [HttpPost]
        public ActionResult PostContactMessage(PostContactModel contactInfo)
        {

            if (!ModelState.IsValid) return new HttpStatusCodeResult(403);
            dbCtx.posts.Add(contactInfo);
            dbCtx.SaveChanges();

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("support@gcf-consulting.com");
                mail.To.Add("support@gcf-consulting.com");
                mail.Subject = "[CONTACT GCF-WEB] by " + contactInfo.Name;
                mail.Body = $"[Contact Info]{Environment.NewLine}Name: {contactInfo.Name}{Environment.NewLine}Phone Number: {contactInfo.Telephone}{Environment.NewLine}[/Contact Info]{Environment.NewLine}{Environment.NewLine}{contactInfo.Message}";
                mail.ReplyToList.Add(new MailAddress(contactInfo.Email));
                SmtpClient smtpClient = new SmtpClient("send.one.com", 587);
                smtpClient.Credentials = new System.Net.NetworkCredential("support@gcf-consulting.com", "gcf@C0mm0n");
                //smtpClient.UseDefaultCredentials = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;


                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                Response.Write("Could not send the e-mail - error: " + ex.Message);

            }

            return new HttpStatusCodeResult(200);

        }








        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}