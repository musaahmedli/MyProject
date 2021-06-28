
namespace HotelManagementProject
{
    partial class LoginForm
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
            this.txtUserNameLogin = new System.Windows.Forms.TextBox();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserNameLogin
            // 
            this.txtUserNameLogin.BackColor = System.Drawing.Color.BurlyWood;
            this.txtUserNameLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserNameLogin.ForeColor = System.Drawing.Color.White;
            this.txtUserNameLogin.Location = new System.Drawing.Point(95, 149);
            this.txtUserNameLogin.Name = "txtUserNameLogin";
            this.txtUserNameLogin.Size = new System.Drawing.Size(175, 22);
            this.txtUserNameLogin.TabIndex = 0;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.BackColor = System.Drawing.Color.BurlyWood;
            this.txtPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordLogin.ForeColor = System.Drawing.Color.White;
            this.txtPasswordLogin.Location = new System.Drawing.Point(95, 199);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(175, 22);
            this.txtPasswordLogin.TabIndex = 1;
            this.txtPasswordLogin.UseSystemPasswordChar = true;
            this.txtPasswordLogin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Don\'t Have Account?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Welcome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("ROG Fonts", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Login";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(368, 362);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.txtUserNameLogin);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Click += new System.EventHandler(this.LoginForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserNameLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

