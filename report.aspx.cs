using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;

namespace ASPWebApplication
{
    public partial class report : System.Web.UI.Page
    {
        static string connectName = "MS:SQL2019 Bağlantısı"; //web.config dosyasında yer alan bağlantıya atanmış isim/name
        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings[connectName].ConnectionString);
        static string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SessionID"] != null)
            {
                if(!this.IsPostBack)
                {
                    query = "SELECT * FROM DBO_TestTable";
                    SqlCommand command = new SqlCommand(query, connect);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "DataSet1");

                    ReportViewer1.Reset();
                    ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report1.rdlc");
                    ReportDataSource reportDS = new ReportDataSource("UsersTable", dataSet.Tables[0]);
                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportViewer1.LocalReport.DataSources.Add(reportDS);
                    ReportViewer1.LocalReport.Refresh();
                }
            }
            else
            {
                login login = new login();
                login.target = "report.aspx";
                Response.Redirect("login.aspx");
            }
        }
    }
}