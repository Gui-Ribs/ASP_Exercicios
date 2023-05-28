using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeRibeiroCipriano.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Inicio()
        {
            return View();
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

        public ActionResult Nota() 
        {
            return View();
        }
        [HttpGet]
        public ActionResult CalculaNota(int? result) 
        {

            if (result != null)
            {
                int final = 10 - result.Value;

                if (final > 0)
                {
                    ViewBag.result = final;
                }
                else
                    return View("Nota");
            }
            else
                return View("Nota");

            return View();
        
        }
    }
}