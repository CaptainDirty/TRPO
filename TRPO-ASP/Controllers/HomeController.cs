using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TRPO_Lab3.Lib;

namespace TRPO_ASP.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index(string radius, string height)
        {
            double Square = new Math_1().Formula(Convert.ToDouble(radius), Convert.ToDouble(height));
            ViewBag.result = Square;
            return View();
        }
        
        
    }
}