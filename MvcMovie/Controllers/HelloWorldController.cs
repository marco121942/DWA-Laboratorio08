using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        /*
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
        */
        /*
        public string Index()
        {
            return "Esta es mi accion por <b< Defecto</b>....";
        }
        */
        //public string Welcome()
        //{
        //    return "Este es el metodo de accion de bienvenida.... ";
        //}
        public string Welcome2(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello" + name + ", NumTimes is: " + numTimes);                          
        }

        public string Welcome3(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello" + name + ", ID: " + ID);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }


    }
}