using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailKeeperApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> emailAddList = new List<string>(0); 
        private void addButton_Click(object sender, EventArgs e)
        {
            //Regex myRegularExpression = new
            //                Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            string email = emailToAddTextBox.Text;
            if (email.Contains("@") & email.Contains("."))
            {
                emailAddList.Add(email);
                addedEmailListBox.Items.Add(email);
                emailToAddTextBox.Text = String.Empty;

            }
            else
            {
                MessageBox.Show("Enter Valid email");
                emailToAddTextBox.Text = String.Empty;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchEmailListBox.Items.Clear();
            string searchEmail = emailToSearchTextBox.Text;
            foreach (string Email in emailAddList)
            {
                if (Email.Contains(searchEmail))
                {
                    searchEmailListBox.Items.Add(Email);
                }
                
            }
            
        }
    }
}
