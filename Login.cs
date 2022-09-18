namespace Millonario
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            System.Diagnostics.Debug.WriteLine("Username: " + username);
            System.Diagnostics.Debug.WriteLine("Password: " + password);

            bool valid = false;

            for (int i = 0; i < Program.userList.Count; i++)
            {
                User user = Program.userList[i];
                if ((username == user.Username || username == user.Email) && password == user.Password)
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

        private void btnLoginSignup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();

            this.Hide();
            signup.Show();
        }
    }
}