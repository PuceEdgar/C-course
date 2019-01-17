namespace WindowsFormsApp1
{
    partial class frmRegistrationForm
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
            this.components = new System.ComponentModel.Container();
            this.lblCommonInfo = new System.Windows.Forms.Label();
            this.lblContactInfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblSsn = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.txtSsn = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnInsertTestData = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblFullAddress = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtFullAddress = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCommonInfo
            // 
            this.lblCommonInfo.AutoSize = true;
            this.lblCommonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommonInfo.Location = new System.Drawing.Point(49, 25);
            this.lblCommonInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommonInfo.Name = "lblCommonInfo";
            this.lblCommonInfo.Size = new System.Drawing.Size(167, 29);
            this.lblCommonInfo.TabIndex = 0;
            this.lblCommonInfo.Text = "Common Info";
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.AutoSize = true;
            this.lblContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactInfo.Location = new System.Drawing.Point(49, 290);
            this.lblContactInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(151, 29);
            this.lblContactInfo.TabIndex = 1;
            this.lblContactInfo.Text = "Contact Info";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(73, 85);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(51, 119);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(76, 20);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.Location = new System.Drawing.Point(52, 154);
            this.lblBirthdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(77, 20);
            this.lblBirthdate.TabIndex = 5;
            this.lblBirthdate.Text = "Birthdate";
            // 
            // lblSsn
            // 
            this.lblSsn.AutoSize = true;
            this.lblSsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSsn.Location = new System.Drawing.Point(85, 188);
            this.lblSsn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSsn.Name = "lblSsn";
            this.lblSsn.Size = new System.Drawing.Size(43, 20);
            this.lblSsn.TabIndex = 6;
            this.lblSsn.Text = "SSN";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(63, 220);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(64, 20);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(72, 346);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(71, 380);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 20);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(177, 81);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 26);
            this.txtName.TabIndex = 15;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(177, 116);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(183, 26);
            this.txtSurname.TabIndex = 16;
            this.txtSurname.Validating += new System.ComponentModel.CancelEventHandler(this.txtSurname_Validating);
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthdate.Location = new System.Drawing.Point(177, 150);
            this.txtBirthdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.Size = new System.Drawing.Size(183, 26);
            this.txtBirthdate.TabIndex = 17;
            this.txtBirthdate.Validating += new System.ComponentModel.CancelEventHandler(this.txtBirthdate_Validating);
            // 
            // txtSsn
            // 
            this.txtSsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSsn.Location = new System.Drawing.Point(177, 185);
            this.txtSsn.Margin = new System.Windows.Forms.Padding(4);
            this.txtSsn.Name = "txtSsn";
            this.txtSsn.Size = new System.Drawing.Size(183, 26);
            this.txtSsn.TabIndex = 18;
            this.txtSsn.Validating += new System.ComponentModel.CancelEventHandler(this.txtSsn_Validating);
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(177, 219);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(183, 28);
            this.cmbGender.TabIndex = 19;
            this.cmbGender.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGender_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(177, 342);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 26);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(177, 377);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(183, 26);
            this.txtPhone.TabIndex = 22;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(692, 372);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // btnInsertTestData
            // 
            this.btnInsertTestData.Location = new System.Drawing.Point(584, 294);
            this.btnInsertTestData.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertTestData.Name = "btnInsertTestData";
            this.btnInsertTestData.Size = new System.Drawing.Size(184, 28);
            this.btnInsertTestData.TabIndex = 29;
            this.btnInsertTestData.Text = "Insert test data";
            this.btnInsertTestData.UseVisualStyleBackColor = true;
            this.btnInsertTestData.Click += new System.EventHandler(this.btnInsertTestData_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(471, 36);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 17);
            this.lblAddress.TabIndex = 30;
            this.lblAddress.Text = "Address";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(462, 85);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(57, 17);
            this.lblCountry.TabIndex = 31;
            this.lblCountry.Text = "Country";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(462, 119);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 32;
            this.lblCity.Text = "City";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(462, 156);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(46, 17);
            this.lblStreet.TabIndex = 33;
            this.lblStreet.Text = "Street";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(465, 188);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(65, 17);
            this.lblZipCode.TabIndex = 34;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblFullAddress
            // 
            this.lblFullAddress.AutoSize = true;
            this.lblFullAddress.Location = new System.Drawing.Point(465, 220);
            this.lblFullAddress.Name = "lblFullAddress";
            this.lblFullAddress.Size = new System.Drawing.Size(86, 17);
            this.lblFullAddress.TabIndex = 35;
            this.lblFullAddress.Text = "Full Address";
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(571, 81);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(121, 24);
            this.cmbCountry.TabIndex = 36;
            this.cmbCountry.Validating += new System.ComponentModel.CancelEventHandler(this.cmbCountry_Validating);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(571, 117);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 22);
            this.txtCity.TabIndex = 37;
            this.txtCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtCity_Validating);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(571, 153);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 22);
            this.txtStreet.TabIndex = 38;
            this.txtStreet.Validating += new System.ComponentModel.CancelEventHandler(this.txtStreet_Validating);
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(571, 189);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(100, 22);
            this.txtZipCode.TabIndex = 39;
            this.txtZipCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtZipCode_Validating);
            // 
            // txtFullAddress
            // 
            this.txtFullAddress.Location = new System.Drawing.Point(571, 222);
            this.txtFullAddress.Name = "txtFullAddress";
            this.txtFullAddress.ReadOnly = true;
            this.txtFullAddress.Size = new System.Drawing.Size(224, 22);
            this.txtFullAddress.TabIndex = 40;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(561, 372);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(97, 28);
            this.btnPreview.TabIndex = 41;
            this.btnPreview.Text = "Prieview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // frmRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 426);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.txtFullAddress);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.lblFullAddress);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnInsertTestData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtSsn);
            this.Controls.Add(this.txtBirthdate);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblSsn);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblContactInfo);
            this.Controls.Add(this.lblCommonInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistrationForm";
            this.Text = "New Employee";
            this.Load += new System.EventHandler(this.frmRegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCommonInfo;
        private System.Windows.Forms.Label lblContactInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblSsn;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtBirthdate;
        private System.Windows.Forms.TextBox txtSsn;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.Button btnInsertTestData;
        private System.Windows.Forms.TextBox txtFullAddress;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblFullAddress;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnPreview;
    }
}

