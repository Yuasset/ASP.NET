using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ASPWebApplication
{
    public partial class register : System.Web.UI.Page
    {
        static string connectName = "MS:SQL2019 Bağlantısı"; //web.config dosyasında yer alan bağlantıya atanmış isim/name
        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings[connectName].ConnectionString);
        static string query;
        
        void clear()
        {
            regUserID.Text = "";
            regPassword.Text = "";
            regEMail.Text = "";
            regName.Text = "";
            regSurname.Text = "";
            regSex.SelectedValue = null;
            regPhone.Text = "";
        }
        public void Page_Load(object sender, EventArgs e)
        {

        }

        public void Register_Button_Click(object sender, EventArgs e)
        {

            query = "Insert into DBO_TestTable (UserID, Password, EMail, Name, Surname, Sex, Phone) values (@UserID, @Password, @EMail, @Name, @Surname, @Sex, @Phone)";
            SqlCommand command = new SqlCommand(query, connect);

            if (regUserID.Text != "" & regPassword.Text != "" & regEMail.Text != "" & regName.Text != "" & regSurname.Text != "" & regSex.SelectedValue != "" & regPhone.Text != "")
            {
                connect.Open();
                try
                {
                    command.Parameters.AddWithValue("@UserID", regUserID.Text);
                    command.Parameters.AddWithValue("@Password", regPassword.Text);
                    command.Parameters.AddWithValue("@EMail", regEMail.Text);
                    command.Parameters.AddWithValue("@Name", regName.Text);
                    command.Parameters.AddWithValue("@Surname", regSurname.Text);
                    command.Parameters.AddWithValue("@Sex", regSex.SelectedValue);
                    command.Parameters.AddWithValue("@Phone", regPhone.Text);
                    command.ExecuteNonQuery();
                    connect.Close();
                    Sonuc.Text = "Kayıt başarılıyla yapıldı";
                }
                catch (Exception)
                {
                    Sonuc.Text = "Kayıt başarısız";
                    connect.Close();
                }
                clear();
            }
            else
            {
                Sonuc.Text = "Boş alan bırakmayınız";
            }
        }
    }
}