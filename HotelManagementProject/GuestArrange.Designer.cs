
namespace HotelManagementProject
{
    partial class GuestArrange
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.dtpckEntry = new System.Windows.Forms.DateTimePicker();
            this.dtpckExit = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnArrangeGst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Guest Name";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(159, 25);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(154, 22);
            this.txtGuestName.TabIndex = 5;
            // 
            // dtpckEntry
            // 
            this.dtpckEntry.Location = new System.Drawing.Point(159, 88);
            this.dtpckEntry.Name = "dtpckEntry";
            this.dtpckEntry.Size = new System.Drawing.Size(200, 22);
            this.dtpckEntry.TabIndex = 7;
            // 
            // dtpckExit
            // 
            this.dtpckExit.Location = new System.Drawing.Point(159, 155);
            this.dtpckExit.Name = "dtpckExit";
            this.dtpckExit.Size = new System.Drawing.Size(200, 22);
            this.dtpckExit.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Entry Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Exit Date";
            // 
            // btnArrangeGst
            // 
            this.btnArrangeGst.Location = new System.Drawing.Point(271, 220);
            this.btnArrangeGst.Name = "btnArrangeGst";
            this.btnArrangeGst.Size = new System.Drawing.Size(88, 32);
            this.btnArrangeGst.TabIndex = 11;
            this.btnArrangeGst.Text = "Arrange Guest";
            this.btnArrangeGst.UseVisualStyleBackColor = true;
            this.btnArrangeGst.Click += new System.EventHandler(this.btnArrangeGst_Click);
            // 
            // GuestArrange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 264);
            this.Controls.Add(this.btnArrangeGst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpckExit);
            this.Controls.Add(this.dtpckEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGuestName);
            this.Name = "GuestArrange";
            this.Text = "GuestArrange";
            this.Load += new System.EventHandler(this.GuestArrange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.DateTimePicker dtpckEntry;
        private System.Windows.Forms.DateTimePicker dtpckExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnArrangeGst;
    }
}