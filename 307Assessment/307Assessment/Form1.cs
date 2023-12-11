using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using _307Assessment;

namespace _307Assessment
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {


            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }


            using (mssql2203912Entities _307_Staff = new mssql2203912Entities())
            {
                // Check if a user with the provided email and password exists
                var user = _307_Staff.C307_Staff.FirstOrDefault(u => u.Email == email && u.Password == password);

                if (user != null)
                {
                    MessageBox.Show("Login successful!");
                    StaffPage StaffPage = new StaffPage();
                    StaffPage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.");
                }
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
