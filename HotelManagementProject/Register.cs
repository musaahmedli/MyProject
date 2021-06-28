using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace HotelManagementProject
{
    public partial class Register : Form
    {
        private string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=true;";

        public static string getHash(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            
            string username = txtUserNameRegister.Text;
            string password = getHash(txtPassRegister.Text);
            string query = @"insert into Users values(@username,@password)";
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.ExecuteNonQuery();
            connection.Close();

            this.Hide();
            LoginForm frmLogin = new LoginForm();
            frmLogin.ShowDialog();
            this.Close();
            
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUserNameRegister_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassRegister_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
