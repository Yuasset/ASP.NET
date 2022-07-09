using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebApplication
{
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SessionID"] != null)
            {
                lblBilgi.Text = "Sayın, " + Session["SessionName&Surname"].ToString() + " sisteme hoşgeldiniz.";
            }
            else
            {
                lblBilgi.Text = "";
                //login login = new login();
                //login.target = "homepage.aspx";
                //Response.Redirect("login.aspx");
            }
        }
    }
}