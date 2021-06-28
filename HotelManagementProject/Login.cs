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
    public partial class LoginForm : Form
    {
        private const string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=true;";
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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(0,0,255);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register regForm = new Register();
            regForm.ShowDialog();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hashPassLogin= getHash(txtPasswordLogin.Text);

            DataTable dt = new DataTable(); 
            string query = "select count(UserName) from Users where UserName = @username and UserPassword= @password";
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username",txtUserNameLogin.Text);
            command.Parameters.AddWithValue("@password",hashPassLogin);

            int count = (int)command.ExecuteScalar();

            if(count == 1)
            {
                this.Hide();
                MainMenuForm mainForm = new MainMenuForm();
                mainForm.ShowDialog();
                this.Close();
            } 
            else if (count == 0)
            {
                MessageBox.Show("wrong password or username");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(0, 0, 0);
        }
    }
}
