using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using interview1.Models;

namespace interview1.Controler
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult bookList()
        {
            represent list = new represent();
            list.bookListFromTable();
            return View(list);
        }

        public ActionResult bookAddition()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post), ValidateAntiForgeryToken]
        public ActionResult bookAddition(ReleaseBuild release)
        {
            if(string.IsNullOrEmpty(release.Name) || string.IsNullOrEmpty(release.Language) || string.IsNullOrEmpty(release.Author) || release.Number == 0){
                ViewBag.Error = "Error";
                return View();
            }
            else
            {
                int success = new represent().updateValues(release);
                return View("bookDetail", success);
            }
            
        }

        public ActionResult bookDetail(int section)
        {
            represent bookDetails = new represent();
            bookDetails.singleBookDetails(section);
            return View(bookDetails);
        }

        public ActionResult bookSearch()
        {
            return View();
        }
    }
}