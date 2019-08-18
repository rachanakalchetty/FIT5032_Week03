using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.HelloWorld;
using WebApplication1.Exercise;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Message = "This is my first c# program.";
            HelloWorld.Hello h = new HelloWorld.Hello();
            ViewBag.Message = h.GetHello();
            ExampleDictionary ed = new ExampleDictionary();
   
            ed.Example();



            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}