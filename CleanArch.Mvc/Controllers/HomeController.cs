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
using System.Xml;
using System.Xml.Serialization;
using FastReport.Web;
using FastReport.Export.PdfSimple;
using static CleanArch.Mvc.Startup;
using FastReport.Utils;
using FastReport.Export.Image;

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
            //GenerateReportTest();
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

        public IActionResult GenerateReportTest()
        {
            try
            {
               
                Config.WebMode = true;
                StringWriter sw = new StringWriter();
                XmlTextWriter tw = null;
                List<School> listaEscuelasActivas = _schoolService.GetAllSchools().Where(s => s.Active == true).ToList();
                XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(listaEscuelasActivas.GetType());
                tw = new XmlTextWriter(sw);
               serializer.Serialize(tw, listaEscuelasActivas);
             
               //​DataSet dataSet = new System.Data.DataSet();
             
                 WebReport report = new WebReport();
              
                // load the existing report
                report.Report.Load("report.frx");
                // Add DataTable Row
              
                // register the data
                report.Report.RegisterData(sw.ToString(), "Schools");
                report.Report.GetDataSource("Schools").Enabled = true;

                report.Report.SetParameterValue("Name", "Colegio Guadalupe Victoria");
                DataBand db1 = (DataBand)report.Report.FindObject("Data1");
                db1.DataSource = report.Report.GetDataSource("Schools");
                //create export instance

                //ExportBase ex = new ExportBase();
                //r

                report.Report.Prepare();


                // save file in stream
                using (MemoryStream stream = new MemoryStream()) // Create a stream for the report
                {

                    //ImageExport png = new ImageExport();
                    PDFSimpleExport pdf = new PDFSimpleExport();
                    report.Report.Export(pdf, stream);

                    //png.ImageFormat = ImageExportFormat.Png;
                    //png.SeparateFiles = false;
                    // Use the stream to store the report, so as not to create unnecessary files
                    //report.Export(png, stream);
                    string mime = "application/pdf";
                    return File(stream.ToArray(), mime, "example.pdf"); // attachment
                                                                        //report.Report.Export(new PDFSimpleExport(), stream);
                                                                        //stream.Position = 0;
                                                                        //// return stream in browser
                                                                        //return File(stream, "application/zip", "report.pdf");

                    //report.Save("example.pdf");
                    //FastReport.Export.PdfSimple.PDFSimpleExport export = new FastReport.Export.PdfSimple.PDFSimpleExport();

                    //report.Export(export, "result.pdf");
                    //// free resources used by report
                }



            }
            catch (Exception exception)
            {
                throw exception;
            }
            
        }


        
        public IActionResult About()
        {

            try
            {
                var webReport = new WebReport();

                webReport.Report.Load("report.frx");
                webReport.Report.SetParameterValue("Name", "Colegio Guadalupe Victoria");

                return View(webReport);
            }
            catch (Exception exception)
            {

                throw exception;
            }
           
        }

        public IActionResult Contact()
        {
            return GenerateReportTest();
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
