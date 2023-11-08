using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCrytalReport.Report
{
    public partial class CrystalReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(Server.MapPath("~/test.rpt"));
            CrystalReportViewer1.ReportSource = rd;
            //CrystalReportViewer1.DisplayGroupTree = false;
            CrystalReportViewer1.Visible = true;
        }
    }
}