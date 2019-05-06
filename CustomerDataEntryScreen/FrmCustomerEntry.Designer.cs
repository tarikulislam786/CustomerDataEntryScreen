namespace CustomerDataEntryScreen
{
    partial class frmCustomerDataEntry
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
            this.lblCustomerTxt = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cmbCountryName = new System.Windows.Forms.ComboBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.lblHobby = new System.Windows.Forms.Label();
            this.checkReading = new System.Windows.Forms.CheckBox();
            this.checkPainting = new System.Windows.Forms.CheckBox();
            this.radioUnmarried = new System.Windows.Forms.RadioButton();
            this.radioMarried = new System.Windows.Forms.RadioButton();
            this.btnPreview = new System.Windows.Forms.Button();
            this.groupBoxSex = new System.Windows.Forms.GroupBox();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBoxSex.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerTxt
            // 
            this.lblCustomerTxt.AutoSize = true;
            this.lblCustomerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTxt.Location = new System.Drawing.Point(25, 27);
            this.lblCustomerTxt.Name = "lblCustomerTxt";
            this.lblCustomerTxt.Size = new System.Drawing.Size(122, 17);
            this.lblCustomerTxt.TabIndex = 0;
            this.lblCustomerTxt.Text = "Customer Name :-";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(149, 27);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(121, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(25, 60);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(111, 17);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Country Name :-";
            // 
            // cmbCountryName
            // 
            this.cmbCountryName.FormattingEnabled = true;
            this.cmbCountryName.Location = new System.Drawing.Point(149, 60);
            this.cmbCountryName.Name = "cmbCountryName";
            this.cmbCountryName.Size = new System.Drawing.Size(121, 21);
            this.cmbCountryName.TabIndex = 3;
            this.cmbCountryName.SelectedIndexChanged += new System.EventHandler(this.cmbCountryName_SelectedIndexChanged);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(27, 26);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(61, 24);
            this.radioMale.TabIndex = 5;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(107, 25);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(80, 24);
            this.radioFemale.TabIndex = 6;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // lblHobby
            // 
            this.lblHobby.AutoSize = true;
            this.lblHobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHobby.Location = new System.Drawing.Point(25, 197);
            this.lblHobby.Name = "lblHobby";
            this.lblHobby.Size = new System.Drawing.Size(62, 17);
            this.lblHobby.TabIndex = 7;
            this.lblHobby.Text = "Hobby :-";
            // 
            // checkReading
            // 
            this.checkReading.AutoSize = true;
            this.checkReading.Location = new System.Drawing.Point(149, 199);
            this.checkReading.Name = "checkReading";
            this.checkReading.Size = new System.Drawing.Size(66, 17);
            this.checkReading.TabIndex = 8;
            this.checkReading.Text = "Reading";
            this.checkReading.UseVisualStyleBackColor = true;
            // 
            // checkPainting
            // 
            this.checkPainting.AutoSize = true;
            this.checkPainting.Location = new System.Drawing.Point(235, 199);
            this.checkPainting.Name = "checkPainting";
            this.checkPainting.Size = new System.Drawing.Size(64, 17);
            this.checkPainting.TabIndex = 9;
            this.checkPainting.Text = "Painting";
            this.checkPainting.UseVisualStyleBackColor = true;
            // 
            // radioUnmarried
            // 
            this.radioUnmarried.AutoSize = true;
            this.radioUnmarried.Location = new System.Drawing.Point(107, 25);
            this.radioUnmarried.Name = "radioUnmarried";
            this.radioUnmarried.Size = new System.Drawing.Size(101, 24);
            this.radioUnmarried.TabIndex = 12;
            this.radioUnmarried.TabStop = true;
            this.radioUnmarried.Text = "Unmarried";
            this.radioUnmarried.UseVisualStyleBackColor = true;
            // 
            // radioMarried
            // 
            this.radioMarried.AutoSize = true;
            this.radioMarried.Location = new System.Drawing.Point(6, 25);
            this.radioMarried.Name = "radioMarried";
            this.radioMarried.Size = new System.Drawing.Size(80, 24);
            this.radioMarried.TabIndex = 11;
            this.radioMarried.TabStop = true;
            this.radioMarried.Text = "Married";
            this.radioMarried.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPreview.Location = new System.Drawing.Point(28, 304);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(92, 33);
            this.btnPreview.TabIndex = 13;
            this.btnPreview.Text = "Add Customer";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // groupBoxSex
            // 
            this.groupBoxSex.Controls.Add(this.radioMale);
            this.groupBoxSex.Controls.Add(this.radioFemale);
            this.groupBoxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSex.Location = new System.Drawing.Point(28, 138);
            this.groupBoxSex.Name = "groupBoxSex";
            this.groupBoxSex.Size = new System.Drawing.Size(201, 56);
            this.groupBoxSex.TabIndex = 14;
            this.groupBoxSex.TabStop = false;
            this.groupBoxSex.Text = "Sex :-";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.radioMarried);
            this.groupBoxStatus.Controls.Add(this.radioUnmarried);
            this.groupBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStatus.Location = new System.Drawing.Point(28, 226);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(210, 56);
            this.groupBoxStatus.TabIndex = 15;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status  :-";
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Location = new System.Drawing.Point(338, 17);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.Size = new System.Drawing.Size(613, 320);
            this.dtgCustomer.TabIndex = 16;
            this.dtgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellClick);
            this.dtgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(226, 304);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 33);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(126, 304);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 33);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblEmail.Location = new System.Drawing.Point(25, 104);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 17);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email :-";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(149, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // frmCustomerDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 359);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtgCustomer);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.groupBoxSex);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.checkPainting);
            this.Controls.Add(this.checkReading);
            this.Controls.Add(this.lblHobby);
            this.Controls.Add(this.cmbCountryName);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerTxt);
            this.Name = "frmCustomerDataEntry";
            this.Text = "Customer Data Entry Screen";
            this.Load += new System.EventHandler(this.frmCustomerDataEntry_Load);
            this.groupBoxSex.ResumeLayout(false);
            this.groupBoxSex.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerTxt;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cmbCountryName;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.Label lblHobby;
        private System.Windows.Forms.CheckBox checkReading;
        private System.Windows.Forms.CheckBox checkPainting;
        private System.Windows.Forms.RadioButton radioUnmarried;
        private System.Windows.Forms.RadioButton radioMarried;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.GroupBox groupBoxSex;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.DataGridView dtgCustomer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
    }
}

