namespace CustomerDataEntryScreen
{
    partial class login
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblCustomerData = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCountryData = new System.Windows.Forms.Label();
            this.lblSexData = new System.Windows.Forms.Label();
            this.lblHobbiesData = new System.Windows.Forms.Label();
            this.lblStatusData = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblUserName.Location = new System.Drawing.Point(12, 28);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(92, 22);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username";
            // 
            // lblCustomerData
            // 
            this.lblCustomerData.AutoSize = true;
            this.lblCustomerData.Location = new System.Drawing.Point(118, 19);
            this.lblCustomerData.Name = "lblCustomerData";
            this.lblCustomerData.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerData.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblPassword.Location = new System.Drawing.Point(12, 79);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 22);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblCountryData
            // 
            this.lblCountryData.AutoSize = true;
            this.lblCountryData.Location = new System.Drawing.Point(118, 49);
            this.lblCountryData.Name = "lblCountryData";
            this.lblCountryData.Size = new System.Drawing.Size(0, 13);
            this.lblCountryData.TabIndex = 3;
            // 
            // lblSexData
            // 
            this.lblSexData.AutoSize = true;
            this.lblSexData.Location = new System.Drawing.Point(118, 86);
            this.lblSexData.Name = "lblSexData";
            this.lblSexData.Size = new System.Drawing.Size(0, 13);
            this.lblSexData.TabIndex = 5;
            // 
            // lblHobbiesData
            // 
            this.lblHobbiesData.AutoSize = true;
            this.lblHobbiesData.Location = new System.Drawing.Point(118, 127);
            this.lblHobbiesData.Name = "lblHobbiesData";
            this.lblHobbiesData.Size = new System.Drawing.Size(0, 13);
            this.lblHobbiesData.TabIndex = 7;
            // 
            // lblStatusData
            // 
            this.lblStatusData.AutoSize = true;
            this.lblStatusData.Location = new System.Drawing.Point(118, 156);
            this.lblStatusData.Name = "lblStatusData";
            this.lblStatusData.Size = new System.Drawing.Size(0, 13);
            this.lblStatusData.TabIndex = 9;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.Location = new System.Drawing.Point(121, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(121, 83);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.Color.Sienna;
            this.btnSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnSignin.Location = new System.Drawing.Point(121, 127);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(88, 32);
            this.btnSignin.TabIndex = 12;
            this.btnSignin.Text = "Login";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Sienna;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnClose.Location = new System.Drawing.Point(215, 127);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 32);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(360, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblStatusData);
            this.Controls.Add(this.lblHobbiesData);
            this.Controls.Add(this.lblSexData);
            this.Controls.Add(this.lblCountryData);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblCustomerData);
            this.Controls.Add(this.lblUserName);
            this.Name = "login";
            this.Text = "Login Customer";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblCustomerData;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCountryData;
        private System.Windows.Forms.Label lblSexData;
        private System.Windows.Forms.Label lblHobbiesData;
        private System.Windows.Forms.Label lblStatusData;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Button btnClose;
    }
}