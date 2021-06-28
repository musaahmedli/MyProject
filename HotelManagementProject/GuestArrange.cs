using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementProject
{
    public partial class GuestArrange : Form
    {
        private int _RoomNumber;
        private int _RoomFee;
        private string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=true;";
        public GuestArrange(int roomNumber,int roomFee)
        {
            _RoomNumber = roomNumber;
            _RoomFee = roomFee;
            InitializeComponent();
        }

        private void GuestArrange_Load(object sender, EventArgs e)
        {
            

        }

        private void btnArrangeGst_Click(object sender, EventArgs e)
        {
            string query = "insert into GuestsRoom values(@guestname,@roomnumber,@isactive,@entrydate,@exitdate)";
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@guestname", txtGuestName.Text);
            command.Parameters.AddWithValue("@roomnumber", _RoomNumber);
            command.Parameters.AddWithValue("@isactive", false);
            command.Parameters.AddWithValue("@entrydate", dtpckEntry.Value);
            command.Parameters.AddWithValue("@exitdate", dtpckExit.Value);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Guest Arranged");

            this.Hide();
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.ShowDialog();
            this.Close();

        }
    }
}
