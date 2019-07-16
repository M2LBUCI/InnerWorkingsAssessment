using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InnerWorkingsAssessment.Models;

namespace InnerWorkingsAssessment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ////put together simulated input data for Job 1
            //List<PrintItem> printItems = new List<PrintItem>();
            //printItems.Add(new Envelopes(520.00, false));
            //printItems.Add(new Letterhead(1983.37, true));

            ////inject dependencies when constructing the Job
            //Job job = new Job(printItems, true);

            //put together simulated input data for Job 1
            List<PrintItem> printItems = new List<PrintItem>();
            printItems.Add(new Frisbees(19385.38, true));
            printItems.Add(new YoYos(1829, true));

            //inject dependencies when constructing the Job
            Job job = new Job(printItems, true);

            //return the view/viewmodel for display
            return View("Index", job);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This is an assessment for InnerWorkings.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact JobSpring or Laurencio Bucio for a followup interview:";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
