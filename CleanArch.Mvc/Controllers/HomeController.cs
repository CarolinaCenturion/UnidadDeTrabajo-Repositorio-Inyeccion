using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CleanArch.Mvc.Models;
using CleanArch.Application.Interfaces;
using CleanArch.Domain.Models;
using FastReport;
using System.Data;
using System.IO;

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
            GenerateReportTest();
            return View(listSchools);
         
        }
      

        public IActionResult DeleteSchool(int id)
        {
            try
            {
                _schoolService.DeleteSchool(id);
                return RedirectToAction("Index");
            }
            catch (Exception excepcion )
            {
                throw excepcion;
            }
        }

        public async Task<School>  GetDataUpdateSchool(int id)
        {
            try
            {
                return _schoolService.GetDataSchoolById(id);
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
        }

        public async void UpdateSchool(School school)
        {
            try
            {
                _schoolService.UpdateSchool(school);
                Index();
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
        }

        public async void CreateNewSchool(School school)
        {
            try
            {
                _schoolService.CreateSchool(school);
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
        }

        public void GenerateReportTest()
        {
            try
            {
                // create report instance
                Report report = new Report();

                // load the existing report


               
                // Add DataTable Row
                List<School> listaEscuelasActivas = _schoolService.GetAllSchools().Where(s => s.Active == true).ToList();
              
               
                // register the data
                report.RegisterData(listaEscuelasActivas, "tabla");
                report.Load("report.frx");


                DataBand db1 = (DataBand)report.FindObject("Data1");
                db1.DataSource = report.GetDataSource("tabla");
                //create export instance

                //ExportBase ex = new ExportBase();
                //r
                report.Prepare();
                report.Save("example.pdf");
                //FastReport.Export.PdfSimple.PDFSimpleExport export = new FastReport.Export.PdfSimple.PDFSimpleExport();
               
                //report.Export(export, "result.pdf");
                //// free resources used by report
                report.Dispose();
            }
            catch (Exception exception)
            {
                throw exception;
            }
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
