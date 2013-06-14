using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment3Test.Areas.ContactDetails.Models;

namespace Assignment3Test.Areas.ContactDetails.Controllers
{
    public class ManagementController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }        

        [HttpPost]
        public ActionResult Index(Assignment3Test.Areas.ContactDetails.Models.ContactDetails details)
        {
            return View(details);
        }     
    }
}
