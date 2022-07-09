using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static string connectName = "MS:SQL2019 Bağlantısı"; //web.config dosyasında yer alan bağlantıya atanmış isim/name
        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings[connectName].ConnectionString);
        static string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["SessionID"] != null)
            {
                if (!IsPostBack)
                {
                    Clear();
                }
            }
            else
            {
                login login = new login();
                login.target = "lists.aspx";
                Response.Redirect("login.aspx");
            }
        }
        
        void Clear()
        {
            //ID.Text = "";
            UserID.Text = "";
            Password.Text = "";
            EMail.Text = "";
            Name.Text = "";
            Surname.Text = "";
            regSex.SelectedValue = null;
            Phone.Text = "";
        }
            protected void ListsButton_Click(object sender, EventArgs e)
        {
            Clear();
            if (ID.Text != "")
            {
                query = "SELECT * FROM DBO_TestTable WHERE ID=@ID";
                SqlCommand command = new SqlCommand(query, connect);
                connect.Open();

                command.Parameters.AddWithValue("@ID", ID.Text);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ID.Text = reader["ID"].ToString();
                    UserID.Text = reader["UserID"].ToString();
                    Password.Text = reader["Password"].ToString();
                    EMail.Text = reader["EMail"].ToString();
                    Name.Text = reader["Name"].ToString();
                    Surname.Text = reader["Surname"].ToString();
                    regSex.SelectedValue = reader["Sex"].ToString();
                    Phone.Text = reader["Phone"].ToString();
                }
                connect.Close();
                
                if(UserID.Text == "")
                {
                    ID.Text = "";
                    Clear();
                }
            }
            else
            {
                Response.Write("<script>alert('Alanı boş bırakmayınız.');</script>");
                Clear();
            }
        }
    }
}