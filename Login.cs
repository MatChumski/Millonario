using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Millonario
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public List<string> userList = new List<string>();
        public List<string> passwordList = new List<string>();

        private void btnLogin_click(object sender, EventArgs e)
        {

            userList.Add("admin");
            passwordList.Add("admin123");
            userList.Add("mateo");
            passwordList.Add("mateo123");
            userList.Add("MatChumski");
            passwordList.Add("02040521lol");

            string username = txtUser.Text;
            string password = txtPassword.Text;

            System.Diagnostics.Debug.WriteLine("Username: " + username);
            System.Diagnostics.Debug.WriteLine("Password: " + password);

            bool valid = false;

            for (int i = 0; i < userList.Count; i++)
            {
                if (username == userList[i] && password == passwordList[i])
                {
                    valid = true;
                    break;
                }
            }
            if (valid)
            {
                System.Diagnostics.Debug.WriteLine("bruh");
                lblIncorrecto.ForeColor = Color.Transparent;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("bruhnt");
                lblIncorrecto.ForeColor = Color.Red;
            }


        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario/Email";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario/Email")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.LightGray;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.DarkGray;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.LightGray;
            }
        }
    }
}