using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HavingYourCoffeeMVCExample.Controllers
{
    public class RomanNumeralController : Controller
    {
        //
        // GET: /RomanNumeral/

        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult ConvertToRoman(string id)
        {
            return Json("I");
        }
    }
}
