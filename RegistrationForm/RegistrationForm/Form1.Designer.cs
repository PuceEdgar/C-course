namespace RegistrationForm
{
    partial class Form1
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RepeatPasswordLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.SSNLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.RepeatPasswordBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.CodeBox = new System.Windows.Forms.TextBox();
            this.NamewarningLabel = new System.Windows.Forms.Label();
            this.SurnamewarningLabel = new System.Windows.Forms.Label();
            this.FullNameShow = new System.Windows.Forms.Label();
            this.BirthdaywarningLabel = new System.Windows.Forms.Label();
            this.SSNResultLabel = new System.Windows.Forms.Label();
            this.BirthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.PassWarningLabel = new System.Windows.Forms.Label();
            this.PassRepeatWarningLabel = new System.Windows.Forms.Label();
            this.EmailWarningLabel = new System.Windows.Forms.Label();
            this.SSNBox = new System.Windows.Forms.MaskedTextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.GeneratedCodeLabel = new System.Windows.Forms.Label();
            this.SSNwarningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(110, 39);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(110, 69);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(65, 17);
            this.SurnameLabel.TabIndex = 1;
            this.SurnameLabel.Text = "Surname";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(110, 96);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(71, 17);
            this.FullNameLabel.TabIndex = 2;
            this.FullNameLabel.Text = "Full Name";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(110, 126);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(69, 17);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // RepeatPasswordLabel
            // 
            this.RepeatPasswordLabel.AutoSize = true;
            this.RepeatPasswordLabel.Location = new System.Drawing.Point(110, 164);
            this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            this.RepeatPasswordLabel.Size = new System.Drawing.Size(119, 17);
            this.RepeatPasswordLabel.TabIndex = 4;
            this.RepeatPasswordLabel.Text = "Repeat Password";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(110, 195);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(60, 17);
            this.BirthdayLabel.TabIndex = 5;
            this.BirthdayLabel.Text = "Birthday";
            // 
            // SSNLabel
            // 
            this.SSNLabel.AutoSize = true;
            this.SSNLabel.Location = new System.Drawing.Point(110, 229);
            this.SSNLabel.Name = "SSNLabel";
            this.SSNLabel.Size = new System.Drawing.Size(36, 17);
            this.SSNLabel.TabIndex = 6;
            this.SSNLabel.Text = "SSN";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(113, 261);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(47, 17);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "E-mail";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(113, 294);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(41, 17);
            this.CodeLabel.TabIndex = 8;
            this.CodeLabel.Text = "Code";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(235, 39);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(182, 22);
            this.NameBox.TabIndex = 9;
            this.NameBox.Leave += new System.EventHandler(this.NameBox_Leave);
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(235, 69);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(182, 22);
            this.SurnameBox.TabIndex = 10;
            this.SurnameBox.Leave += new System.EventHandler(this.SurnameBox_Leave);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(235, 126);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(182, 22);
            this.PasswordBox.TabIndex = 11;
            this.PasswordBox.Leave += new System.EventHandler(this.PasswordBox_Leave);
            // 
            // RepeatPasswordBox
            // 
            this.RepeatPasswordBox.Location = new System.Drawing.Point(235, 164);
            this.RepeatPasswordBox.Name = "RepeatPasswordBox";
            this.RepeatPasswordBox.PasswordChar = '*';
            this.RepeatPasswordBox.Size = new System.Drawing.Size(182, 22);
            this.RepeatPasswordBox.TabIndex = 12;
            this.RepeatPasswordBox.Leave += new System.EventHandler(this.RepeatPasswordBox_Leave);
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(235, 261);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(182, 22);
            this.EmailBox.TabIndex = 15;
            this.EmailBox.Leave += new System.EventHandler(this.EmailBox_Leave);
            // 
            // CodeBox
            // 
            this.CodeBox.Location = new System.Drawing.Point(235, 294);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(182, 22);
            this.CodeBox.TabIndex = 16;
            // 
            // NamewarningLabel
            // 
            this.NamewarningLabel.AutoSize = true;
            this.NamewarningLabel.ForeColor = System.Drawing.Color.Red;
            this.NamewarningLabel.Location = new System.Drawing.Point(460, 42);
            this.NamewarningLabel.Name = "NamewarningLabel";
            this.NamewarningLabel.Size = new System.Drawing.Size(119, 17);
            this.NamewarningLabel.TabIndex = 17;
            this.NamewarningLabel.Text = "Name is not valid!";
            this.NamewarningLabel.Visible = false;
            // 
            // SurnamewarningLabel
            // 
            this.SurnamewarningLabel.AutoSize = true;
            this.SurnamewarningLabel.ForeColor = System.Drawing.Color.Red;
            this.SurnamewarningLabel.Location = new System.Drawing.Point(460, 69);
            this.SurnamewarningLabel.Name = "SurnamewarningLabel";
            this.SurnamewarningLabel.Size = new System.Drawing.Size(139, 17);
            this.SurnamewarningLabel.TabIndex = 18;
            this.SurnamewarningLabel.Text = "Surname is not valid!";
            this.SurnamewarningLabel.Visible = false;
            // 
            // FullNameShow
            // 
            this.FullNameShow.AutoSize = true;
            this.FullNameShow.Location = new System.Drawing.Point(235, 98);
            this.FullNameShow.Name = "FullNameShow";
            this.FullNameShow.Size = new System.Drawing.Size(0, 17);
            this.FullNameShow.TabIndex = 19;
            // 
            // BirthdaywarningLabel
            // 
            this.BirthdaywarningLabel.AutoSize = true;
            this.BirthdaywarningLabel.ForeColor = System.Drawing.Color.Red;
            this.BirthdaywarningLabel.Location = new System.Drawing.Point(460, 204);
            this.BirthdaywarningLabel.Name = "BirthdaywarningLabel";
            this.BirthdaywarningLabel.Size = new System.Drawing.Size(156, 17);
            this.BirthdaywarningLabel.TabIndex = 22;
            this.BirthdaywarningLabel.Text = "Please enter valid date!";
            this.BirthdaywarningLabel.Visible = false;
            // 
            // SSNResultLabel
            // 
            this.SSNResultLabel.AutoSize = true;
            this.SSNResultLabel.Location = new System.Drawing.Point(235, 228);
            this.SSNResultLabel.Name = "SSNResultLabel";
            this.SSNResultLabel.Size = new System.Drawing.Size(0, 17);
            this.SSNResultLabel.TabIndex = 23;
            this.SSNResultLabel.Visible = false;
            // 
            // BirthdayPicker
            // 
            this.BirthdayPicker.Location = new System.Drawing.Point(235, 199);
            this.BirthdayPicker.Name = "BirthdayPicker";
            this.BirthdayPicker.Size = new System.Drawing.Size(200, 22);
            this.BirthdayPicker.TabIndex = 13;
            this.BirthdayPicker.ValueChanged += new System.EventHandler(this.BirthdayPicker_Leave);
            this.BirthdayPicker.Leave += new System.EventHandler(this.BirthdayPicker_Leave);
            // 
            // PassWarningLabel
            // 
            this.PassWarningLabel.AutoSize = true;
            this.PassWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.PassWarningLabel.Location = new System.Drawing.Point(460, 126);
            this.PassWarningLabel.Name = "PassWarningLabel";
            this.PassWarningLabel.Size = new System.Drawing.Size(188, 17);
            this.PassWarningLabel.TabIndex = 20;
            this.PassWarningLabel.Text = "Please enter valid password!";
            this.PassWarningLabel.Visible = false;
            // 
            // PassRepeatWarningLabel
            // 
            this.PassRepeatWarningLabel.AutoSize = true;
            this.PassRepeatWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.PassRepeatWarningLabel.Location = new System.Drawing.Point(460, 164);
            this.PassRepeatWarningLabel.Name = "PassRepeatWarningLabel";
            this.PassRepeatWarningLabel.Size = new System.Drawing.Size(263, 17);
            this.PassRepeatWarningLabel.TabIndex = 21;
            this.PassRepeatWarningLabel.Text = "Password didn\'t match! Please Try again";
            this.PassRepeatWarningLabel.Visible = false;
            // 
            // EmailWarningLabel
            // 
            this.EmailWarningLabel.AutoSize = true;
            this.EmailWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.EmailWarningLabel.Location = new System.Drawing.Point(460, 261);
            this.EmailWarningLabel.Name = "EmailWarningLabel";
            this.EmailWarningLabel.Size = new System.Drawing.Size(99, 17);
            this.EmailWarningLabel.TabIndex = 24;
            this.EmailWarningLabel.Text = "Email not valid";
            this.EmailWarningLabel.Visible = false;
            // 
            // SSNBox
            // 
            this.SSNBox.Location = new System.Drawing.Point(235, 223);
            this.SSNBox.Mask = "000000-00000";
            this.SSNBox.Name = "SSNBox";
            this.SSNBox.Size = new System.Drawing.Size(100, 22);
            this.SSNBox.TabIndex = 14;
            this.SSNBox.Leave += new System.EventHandler(this.SSNBox_Leave);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(190, 369);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(145, 43);
            this.UpdateButton.TabIndex = 25;
            this.UpdateButton.Text = "UpdateButton";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(359, 369);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(148, 43);
            this.CancelButton.TabIndex = 26;
            this.CancelButton.Text = "CancelButton";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // GeneratedCodeLabel
            // 
            this.GeneratedCodeLabel.AutoSize = true;
            this.GeneratedCodeLabel.Location = new System.Drawing.Point(460, 298);
            this.GeneratedCodeLabel.Name = "GeneratedCodeLabel";
            this.GeneratedCodeLabel.Size = new System.Drawing.Size(32, 17);
            this.GeneratedCodeLabel.TabIndex = 27;
            this.GeneratedCodeLabel.Text = "123";
            // 
            // SSNwarningLabel
            // 
            this.SSNwarningLabel.AutoSize = true;
            this.SSNwarningLabel.ForeColor = System.Drawing.Color.Red;
            this.SSNwarningLabel.Location = new System.Drawing.Point(463, 227);
            this.SSNwarningLabel.Name = "SSNwarningLabel";
            this.SSNwarningLabel.Size = new System.Drawing.Size(95, 17);
            this.SSNwarningLabel.TabIndex = 28;
            this.SSNwarningLabel.Text = "Not valid SSN";
            this.SSNwarningLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SSNwarningLabel);
            this.Controls.Add(this.GeneratedCodeLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SSNBox);
            this.Controls.Add(this.EmailWarningLabel);
            this.Controls.Add(this.SSNResultLabel);
            this.Controls.Add(this.PassRepeatWarningLabel);
            this.Controls.Add(this.PassWarningLabel);
            this.Controls.Add(this.BirthdaywarningLabel);
            this.Controls.Add(this.FullNameShow);
            this.Controls.Add(this.SurnamewarningLabel);
            this.Controls.Add(this.NamewarningLabel);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.BirthdayPicker);
            this.Controls.Add(this.RepeatPasswordBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.SSNLabel);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.RepeatPasswordLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label RepeatPasswordLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label SSNLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox RepeatPasswordBox;
        private System.Windows.Forms.DateTimePicker BirthdayPicker;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox CodeBox;
        private System.Windows.Forms.Label NamewarningLabel;
        private System.Windows.Forms.Label SurnamewarningLabel;
        private System.Windows.Forms.Label FullNameShow;
        private System.Windows.Forms.Label BirthdaywarningLabel;
        private System.Windows.Forms.Label SSNResultLabel;
        private System.Windows.Forms.Label PassWarningLabel;
        private System.Windows.Forms.Label PassRepeatWarningLabel;
        private System.Windows.Forms.Label EmailWarningLabel;
        private System.Windows.Forms.MaskedTextBox SSNBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label GeneratedCodeLabel;
        private System.Windows.Forms.Label SSNwarningLabel;
    }
}

