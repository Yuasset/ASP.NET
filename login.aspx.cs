using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ASPWebApplication
{
    public partial class login : System.Web.UI.Page
    {
        static string connectName = "MS:SQL2019 Bağlantısı"; //web.config dosyasında yer alan bağlantıya atanmış isim/name
        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings[connectName].ConnectionString);
        static string query;

        public String target = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            connect.Close();

            if (loginID.Text != "" & loginPW.Text != "")
            {
                query = "SELECT * FROM DBO_TestTable WHERE UserID=@UserID AND Password=@Password";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@UserID", loginID.Text);
                command.Parameters.AddWithValue("@Password", loginPW.Text);
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Session["SessionID"] = reader["ID"].ToString();
                    Session["SessionName&Surname"] = reader["Name"].ToString() + " " + reader["Surname"].ToString();

                    if(target == "")
                    {
                        Response.Redirect("homepage.aspx");
                    }
                    else
                    {
                        Response.Redirect(target);
                    }
                }
                else
                {
                    Response.Write("<script>alert('Kullanıcı veya Şire yanlış, tekrar deneyiniz.');</script>");
                }
                reader.Close();
                connect.Close();
            }
            else
            {
                Response.Write("<script>alert('Alanı boş bırakmayınız.');</script>");
            }
            
        }
    }
}