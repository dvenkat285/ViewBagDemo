using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagDemo.Models;

namespace ViewBagDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            ViewBag.Message = "Message from View Bag!!";
            ViewBag.CurrentDate = DateTime.Now.ToLongDateString();

            string[] fruits = { "Apple", "Banana", "Grapes", "Orange" };

            ViewBag.FruitsArray = fruits;


            ViewBag.SportsList = new List<string>()
            {
                "Cricket",
                "Football",
                "Hockey",
                "Baseball"
            };

            Employee Anas = new Employee();

            Anas.EmpId = 22;
            Anas.EmpName = "Anas Khan";
            Anas.EmpDesignation = "Manager";


            ViewBag.Employee = Anas;
            return View();
        }
    }
}