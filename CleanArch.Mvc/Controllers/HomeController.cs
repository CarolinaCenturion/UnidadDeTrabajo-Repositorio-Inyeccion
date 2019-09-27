using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CleanArch.Mvc.Models;
using CleanArch.Application.Interfaces;

namespace CleanArch.Mvc.Controllers
{
    public class HomeController : Controller
    {

        private readonly ISchoolService _schoolService;
        // Se crea el contructor, inyectando la interfaz

        public HomeController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }
        public ViewResult Index()
        {
            IEnumerable<Domain.Models.School> listSchools = _schoolService.GetAllSchools();
            return View(listSchools);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
