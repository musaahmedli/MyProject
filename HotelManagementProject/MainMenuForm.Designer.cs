
namespace HotelManagementProject
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetRoom = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.GuestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuestExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(345, 574);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnGetRoom
            // 
            this.btnGetRoom.Location = new System.Drawing.Point(264, 644);
            this.btnGetRoom.Name = "btnGetRoom";
            this.btnGetRoom.Size = new System.Drawing.Size(105, 45);
            this.btnGetRoom.TabIndex = 2;
            this.btnGetRoom.Text = "Get Room";
            this.btnGetRoom.UseVisualStyleBackColor = true;
            this.btnGetRoom.Click += new System.EventHandler(this.btnGetRoom_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuestId,
            this.GuestName,
            this.RoomNumber});
            this.dataGridView2.Location = new System.Drawing.Point(456, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(302, 574);
            this.dataGridView2.TabIndex = 3;
            // 
            // GuestId
            // 
            this.GuestId.DataPropertyName = "GuestId";
            this.GuestId.HeaderText = "Id";
            this.GuestId.MinimumWidth = 6;
            this.GuestId.Name = "GuestId";
            this.GuestId.Visible = false;
            this.GuestId.Width = 125;
            // 
            // GuestName
            // 
            this.GuestName.DataPropertyName = "GuestName";
            this.GuestName.HeaderText = "Guestname";
            this.GuestName.MinimumWidth = 6;
            this.GuestName.Name = "GuestName";
            this.GuestName.Width = 125;
            // 
            // RoomNumber
            // 
            this.RoomNumber.DataPropertyName = "RoomNumber";
            this.RoomNumber.HeaderText = "Roomnumber";
            this.RoomNumber.MinimumWidth = 6;
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Width = 125;
            // 
            // btnGuestExit
            // 
            this.btnGuestExit.Location = new System.Drawing.Point(661, 644);
            this.btnGuestExit.Name = "btnGuestExit";
            this.btnGuestExit.Size = new System.Drawing.Size(97, 45);
            this.btnGuestExit.TabIndex = 4;
            this.btnGuestExit.Text = "Exit Room";
            this.btnGuestExit.UseVisualStyleBackColor = true;
            this.btnGuestExit.Click += new System.EventHandler(this.btnGuestExit_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 713);
            this.Controls.Add(this.btnGuestExit);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnGetRoom);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetRoom;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnGuestExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
    }
}