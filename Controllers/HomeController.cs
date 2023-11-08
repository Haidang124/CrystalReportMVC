using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCrytalReport.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return View();
            //ReportDocument rd = new ReportDocument();
            //rd.Load(Server.MapPath("~/test.rpt")); // Điều chỉnh tên tệp .rpt và đường dẫn phù hợp

            //// Thực hiện bất kỳ xử lý dữ liệu nào cần thiết ở đây
            ////CrystalReportViewer1.ReportSource = myRPT;

            //var model = new Models.ReportModel
            //{
            //    Report = rd
            //};

            //return View(model);
            return Redirect("Report/CrystalReport.aspx");
            //ExportOptions exportOptions = new ExportOptions();
            //exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            //exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
            //exportOptions.DestinationOptions = new DiskFileDestinationOptions
            //{
            //    DiskFileName = Server.MapPath("~/report.pdf") // Điều chỉnh đường dẫn và tên tệp PDF đích
            //};

            //rd.Export(exportOptions);

            //// Trả về file PDF đã được chuyển đổi
            //return File("~/report.pdf", "application/pdf", "report.pdf");
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
    }
}