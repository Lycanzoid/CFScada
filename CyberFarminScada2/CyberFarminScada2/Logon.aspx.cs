using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CyberFarminScada2
{
    public partial class Logon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Logon_Click(object sender, EventArgs e) 
        {
            MySqlConnection con = new MySqlConnection("Server=wisteria.arvixe.com;Database=greenhouse;Uid=zaghilionheart;Pwd=123456");
            string query = "select count(*) from Registration where Username='" + UserNameTextBox.Text + "'";

            con.Open();
            
            MySqlCommand cmd = new MySqlCommand(query, con);
            //opretter en data reader og Executer MySqlCommand

            int temp = Convert.ToInt32(cmd.ExecuteScalar());

            if (temp == 1)
            {
                string query1 = "Select Password from Registration where Username='" + UserNameTextBox.Text + "'";
                MySqlCommand pass = new MySqlCommand(query1, con);
                string password = pass.ExecuteScalar().ToString();

                if (Decrypt(password) == PasswordTextBox.Text)
                {

                    Session["new"] = UserNameTextBox.Text;


                   Response.Redirect("~/Home.aspx");



                }
                else
                {
                    // InvalidCredentialsMessage.Text = "Invalid Password...!!";
                    InvalidCredentialsMessage.Visible = true;
                }
            }
            else
            {
                // InvalidCredentialsMessage.Text = "Invalid Username...!!";
                InvalidCredentialsMessage.Visible = true;
            }

            con.Close(); 
        }

        private string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}