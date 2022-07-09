using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebApplication
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["SessionID"] != null)
            {
                linklogin.Text = "Çıkış";
            }
            else
            {
                linklogin.Text = "Giriş";
            }
        }

        protected void linklogin_Click(object sender, EventArgs e)
        {
            if(linklogin.Text == "Giriş")
            {
                Response.Redirect("login.aspx");
            }
            else if(linklogin.Text == "Çıkış")
            {
                Session["SessionID"] = null;
                Response.Redirect("login.aspx");
            }
        }
    }
}