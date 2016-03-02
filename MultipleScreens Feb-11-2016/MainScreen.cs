using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleScreens_Feb_11_2016
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
            passwordTBox.PasswordChar = '*';
            passwordTBox.MaxLength = 10;
            usernameTBox.MaxLength = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameInput = usernameTBox.Text;
            string passwordInput = passwordTBox.Text;
            string correctName = "Donny";
            string correctPassword = Convert.ToString("1234");

            //if (nameInput == correctName && passwordInput == correctPassword)  // if the password and username are correct
            //{
                Form f = this.FindForm();
                f.Controls.Remove(this);

                PlayScreen ps = new PlayScreen();
                f.Controls.Add(ps);

                ps.Location = new Point((f.Width - ps.Width) / 2, (f.Height - ps.Height) / 2);
            //} 

            //else 
            //{
                responseLabel.Visible = true; //The " Password and/or Username incorrect :( "
                usernameTBox.Clear();
                passwordTBox.Clear();
            //}
        }
     }
}
