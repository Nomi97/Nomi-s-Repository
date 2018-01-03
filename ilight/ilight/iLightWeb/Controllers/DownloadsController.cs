using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ilight.Models;
using System.Data.Entity;
namespace ilight.Controllers
{
    public class DownloadsController : Controller
    {
        private Context db = new Context();
        // GET: Downloads
        [SessionAuthorize]
        public ActionResult Index()
        {
            var Downloads = db.Downloads.ToList();

            return View(Downloads);
        }
        [SessionAuthorize]
        public ActionResult Download(string pdf)
        {

            pdf = Request.Url.Query.Substring(7).ToString();
            if (pdf != null)
            {
                var pdfPath = "";
                string pdfDownloadName = "";


                switch (pdf)
                {

                    case "test":
                        pdfPath = "~/App_Data/test" + ".txt";
                        pdfDownloadName = "test.txt";
                        return base.File(pdfPath, "application/text", pdfDownloadName);
                        break;
                    case "lesson2":
                        pdfPath = "~/App_Data/Lesson2" + ".pdf";
                        pdfDownloadName = "lesson2.pdf";
                        return base.File(pdfPath, "application/pdf", pdfDownloadName);
                        break;

                }
            }
            else
            {
                TempData["Type"] = "Danger";
                TempData["Message"] = "No file with that name exist!";
                return RedirectToAction("Index", "Downloads");
            }
            TempData["Type"] = "Danger";
            TempData["Message"] = "No file with that name exist!";
            return RedirectToAction("Index", "Home");
        }

    }
}
