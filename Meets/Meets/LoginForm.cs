using Meets.Meetings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meets
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void UsernameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (UsernameTxtBox.Text.Length < 1)
            {
                LoginBtn.Enabled = false;
                return;
            }
            LoginBtn.Enabled = true;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            User.Name = UsernameTxtBox.Text;
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
        }
    }
}
