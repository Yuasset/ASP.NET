using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace ASPWebApplication
{
    public partial class update : System.Web.UI.Page
    {
        static string connectName = "MS:SQL2019 Bağlantısı"; //web.config dosyasında yer alan bağlantıya atanmış isim/name
        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings[connectName].ConnectionString);
        static string query;
        void updateOpen()
        {
            //ID.Enabled = true;
            UserID.Enabled = true;
            Password.Enabled = true;
            EMail.Enabled = true;
            Name.Enabled = true;
            Surname.Enabled = true;
            regSex.Enabled = true;
            Phone.Enabled = true;
        }
        void updateClose()
        {
            //ID.Enabled = false;
            UserID.Enabled = false;
            Password.Enabled = false;
            EMail.Enabled = false;
            Name.Enabled = false;
            Surname.Enabled = false;
            regSex.Enabled = false;
            Phone.Enabled = false;
        }
        void clear()
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
        void reload()
        {
            ID.Text = "";
            clear();
            ID.Enabled = true;
            SelectButton.Enabled = true;
            ProcessButton.Text = "İşlem";
            ProcessButton.Enabled = false;
            ProcessSelect.Items[0].Enabled = true;
            ProcessSelect.SelectedIndex = 0;
            ProcessSelect.Enabled = false;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SessionID"] != null)
            {
                
            }
            else
            {
                Response.Redirect("login.aspx");
                login login = new login();
                login.target = "update.aspx";
            }
        }

        protected void Process_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProcessSelect.SelectedValue == "Update")
            {
                ProcessButton.Text = "Güncelle";
                ProcessButton.Enabled = true;
                ID.Enabled = false;
                SelectButton.Enabled = false;
                ProcessSelect.Items[0].Enabled = false;
                updateOpen();
            }
            else if (ProcessSelect.SelectedValue == "Delete")
            {
                ProcessButton.Text = "Kaldır";
                ProcessButton.Enabled = true;
                ID.Enabled = false;
                SelectButton.Enabled = false;
                ProcessSelect.Items[0].Enabled = false;
                updateClose();
            }
            else
            {
                ProcessButton.Text = "İşlem";
            }
        }

        protected void ProcessButton_Click(object sender, EventArgs e)
        {
            if (ProcessSelect.SelectedValue == "Update")
            {
                query = "UPDATE DBO_TestTable SET UserID=@UserID, Password=@Password, EMail=@EMail, Name=@Name, Surname=@Surname, Sex=@Sex, Phone=@Phone WHERE ID=@ID";
                SqlCommand command = new SqlCommand(query, connect);
                if (UserID.Text != "" & Password.Text != "" & EMail.Text != "" & ID.Text != "" & Name.Text != "" & Surname.Text != "" & regSex.SelectedValue != "" & Phone.Text != "")
                {
                    connect.Open();
                    command.Parameters.AddWithValue("@ID", ID.Text);
                    command.Parameters.AddWithValue("@UserID", UserID.Text);
                    command.Parameters.AddWithValue("@Password", Password.Text);
                    command.Parameters.AddWithValue("@EMail", EMail.Text);
                    command.Parameters.AddWithValue("@Name", Name.Text);
                    command.Parameters.AddWithValue("@Surname", Surname.Text);
                    command.Parameters.AddWithValue("@Sex", regSex.Text);
                    command.Parameters.AddWithValue("@Phone", Phone.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    connect.Close();
                    updateClose();
                    Response.Write("<script>alert('ID: " + ID.Text + " numaralı veride, Güncelleme işlemi başarılı.');</script>");
                    reload();
                    Sonuc.Text = "";
                }
                else
                {
                    Sonuc.Text = "Boş alan bırakmayınız.";
                }
            }
            else if (ProcessSelect.SelectedValue == "Delete")
            {
                query = "DELETE FROM DBO_TestTable WHERE ID=@ID";
                SqlCommand command = new SqlCommand(query, connect);
                connect.Open();
                command.Parameters.AddWithValue("@ID", ID.Text);
                SqlDataReader reader = command.ExecuteReader();
                connect.Close();
                Response.Write("<script>alert('ID: " + ID.Text + " numaralı veride Silme işlemi başarılı.');</script>");
                reload();
            }
        }

        protected void SelectButton_Click(object sender, EventArgs e)
        {
            clear();
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
                if (Name.Text != "")
                {
                    ProcessSelect.Enabled = true;
                }
                else
                {
                    ProcessSelect.Enabled = false;
                }
            }
            else
            {
                Response.Write("<script>alert('Alanı boş bırakmayınız.');</script>");
            }
        }
    }
}