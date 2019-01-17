using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {

        private const string _nameSurnamePattern = "^(?<firstchar>(?=[A-Za-z]))((?<alphachars>[A-Za-z])|(?<specialchars>[A-Za-z]['-](?=[A-Za-z]))|(?<spaces> (?=[A-Za-z])))*$";
        private const string _mailPattern = "([a-zA-Z]+)[.]?([a-zA-Z]+)[@]([a-zA-Z]+)[.]([a-zA-z]+)";
        public Form1()
        {
            InitializeComponent();
        }

        private void NameBox_Leave(object sender, System.EventArgs e)
        {
            if (NameBox.Text.Length == 0)
            {
                NamewarningLabel.Visible = true;
            }

            else if (!Regex.Match(NameBox.Text, _nameSurnamePattern).Success)
            {
                NamewarningLabel.Visible = true;
            }

            else
            {
                NamewarningLabel.Visible = false;
            }

            if (NameBox.Text != "" && SurnameBox.Text != "")
            {
                FullNameShow.Text = NameBox.Text + " " + SurnameBox.Text;
                FullNameShow.Show();
            }
        }

        private void SurnameBox_Leave(object sender, System.EventArgs e)
        {
            if (SurnameBox.Text.Length == 0)
            {
                SurnamewarningLabel.Show();
            }

            else if (!Regex.Match(SurnameBox.Text, _nameSurnamePattern).Success)
            {
                SurnamewarningLabel.Show();
            }

            else
            {
                SurnamewarningLabel.Hide();
            }

            if (NameBox.Text != "" && SurnameBox.Text != "")
            {
                FullNameShow.Text = NameBox.Text + " " + SurnameBox.Text;
                FullNameShow.Show();
                PasswordBox.Focus();
            }
        }

        private void BirthdayPicker_Leave(object sender, System.EventArgs e)
        {
            String input = BirthdayPicker.Text.ToString();
            DateTime inputDate;
            DateTime now = DateTime.Today;

            if (DateTime.TryParse(input, out inputDate))
            {
                int result = DateTime.Compare(inputDate, now);

                if (result > 0)
                {
                    BirthdaywarningLabel.Show();
                }
                BirthdaywarningLabel.Hide();

                String bdayPart = inputDate.ToString("dd/MM/yyyy").Replace(".", "");
                bdayPart = bdayPart.Remove(4, 2);
                SSNBox.Text = bdayPart + "-";
                SSNBox.Focus();
            }

            else
            {
                BirthdaywarningLabel.Show();
            }
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            bool validPass = ValidatePassword(PasswordBox.Text);

            if (PasswordBox.Text.Length < 5)
            {
                PassWarningLabel.Text = "Password must be at least 5 chars long!";
                PassWarningLabel.Show();
            }

            else
            {
                if (validPass)
                {
                    PassWarningLabel.Hide();
                }

                else
                {
                    PassWarningLabel.Text = "Password didn't match criteria!";
                    PassWarningLabel.Show();
                }
            }





        }

        private void RepeatPasswordBox_Leave(object sender, EventArgs e)
        {
            String original = PasswordBox.Text;
            String repeat = RepeatPasswordBox.Text;

            if (original != repeat)
            {
                PassRepeatWarningLabel.Show();
            }

            else
            {
                PassRepeatWarningLabel.Hide();
            }
        }

        static bool ValidatePassword(String password)
        {
            bool isValid;

            if (password.Length >= 5)
            {
                bool hasUpper = false;
                bool hasLower = false;
                bool hasDigit = false;
                bool hasSpecial = false;

                foreach (var c in password)
                {
                    if (char.IsUpper(c)) hasUpper = true;
                    if (char.IsLower(c)) hasLower = true;
                    if (char.IsDigit(c)) hasDigit = true;
                    if (char.IsWhiteSpace(c)) isValid = false;
                    if (!char.IsLetterOrDigit(c)) hasSpecial = true;
                }

                isValid = hasUpper && hasLower && hasDigit && hasSpecial;
            }

            else
            {
                isValid = false;
            }

            return isValid;
        }

        private void SSNBox_Leave(object sender, EventArgs e)
        {
            if (SSNBox.Text.Length < 12 || SSNBox.Text.Contains(" "))
            {
                SSNwarningLabel.Show();
            }

            else
            {
                SSNwarningLabel.Hide();
            }
        }

        private void EmailBox_Leave(object sender, EventArgs e)
        {
            bool validMail = ValidateMail(EmailBox.Text);

            if (validMail)
            {
                EmailWarningLabel.Hide();
            }

            else
            {
                EmailWarningLabel.Show();
            }
        }

        static bool ValidateMail(String mail)
        {
            bool isValid;

            if (mail.Length == 0)
            {
                isValid = false;
            }

            else if (!Regex.Match(mail, _mailPattern).Success)
            {
                isValid = false;
            }

            else
            {
                isValid = true;
            }

            return isValid;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (NamewarningLabel.Visible ||
                SurnamewarningLabel.Visible ||
                PassWarningLabel.Visible ||
                PassRepeatWarningLabel.Visible ||
                BirthdaywarningLabel.Visible ||
                SSNwarningLabel.Visible ||
                EmailWarningLabel.Visible)
            {
                MessageBox.Show("Please fill in all fields!");
            }

            else
            {
                if (GeneratedCodeLabel.Text == CodeBox.Text)
                {
                    MessageBox.Show("Name: " + FullNameShow.Text + "\r\n"
                    + "Birthday: " + BirthdayPicker.Value.ToShortDateString() + "\r\n"
                    + "SSN: " + SSNBox.Text + "\r\n"
                    + "E-mail: " + EmailBox.Text);
                }

                else
                {
                    MessageBox.Show("Wrong code!");
                }
            }


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            NameBox.Text = "";
            SurnameBox.Text = "";
            FullNameShow.Text = "";
            FullNameShow.Hide();
            PasswordBox.Text = "";
            RepeatPasswordBox.Text = "";
            BirthdayPicker.Value.ToLocalTime();
            SSNBox.Text = "";
            EmailBox.Text = "";
            CodeBox.Text = "";

            NamewarningLabel.Hide();
            SurnamewarningLabel.Hide();
            BirthdaywarningLabel.Hide();
            PassWarningLabel.Hide();
            PassRepeatWarningLabel.Hide();
            SSNwarningLabel.Hide();
            EmailWarningLabel.Hide();

            NameBox.Focus();
        }


    }
}
