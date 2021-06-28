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
    public partial class MainMenuForm : Form
    {
        private string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=true;";
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = @"select *from Rooms
                            where RoomNumber in(select RoomNumber from Rooms
                            except
                            select RoomNumber
                            from GuestsRoom
                            where Isactive = 0)";

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            string query2 = @"select GuestId,GuestName,RoomNumber from GuestsRoom where IsActive = 0";

            SqlCommand command1 = new SqlCommand(query2, connection);
            SqlDataAdapter adapter2 = new SqlDataAdapter(command1);

            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = dt2;

            connection.Close();
        }

        private void btnGetRoom_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGetRoom_Click_1(object sender, EventArgs e)
        {
            int roomNumber = (int)dataGridView1.SelectedRows[0].Cells["RoomNumber"].Value;
            int roomFee = (int)dataGridView1.SelectedRows[0].Cells["RoomFee"].Value;
            this.Hide();
            GuestArrange guestArrange = new GuestArrange(roomNumber,roomFee);
            guestArrange.ShowDialog();
            this.Close();
        }

        private void btnGuestExit_Click(object sender, EventArgs e)
        {
            int id =(int)dataGridView2.SelectedRows[0].Cells["GuestId"].Value;
            string query = $"update GuestsRoom set IsActive = 1 where GuestId ={id} ";
            SqlConnection connection = new SqlConnection(ConnectionString);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery();
            MessageBox.Show("Guest Exited");
            connection.Close();
            this.Hide();
            MainMenuForm mainmenu = new MainMenuForm();
            mainmenu.ShowDialog();
            this.Close();
        }
    }
}
