using System.Net.Mail;
using System.Windows.Forms;

namespace Millonario
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        /* 
         * CHECK IF A STRING IS A VALID E-MAIL ADDRESS
         * 
         * MailAdress is an object provided by C# itself
         * Tries to create a Mail Address Object, and if it fails,
         * it means that the string is not a valid Address
         */
        public bool CheckEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        /*
         * BTN SIGNUP
         */
        private void btnSignupSignup_Click(object sender, EventArgs e)
        {
            string username = txtSignupUser.Text;
            string email = txtSignupEmail.Text;
            string pwd = txtSignupPwd.Text;
            string pwd2 = txtSignupPwd2.Text;

            bool allInfo = true;

            if (username == "Usuario" ||
                email == "E-Mail" ||
                pwd == "Contraseña" ||
                pwd2 == "Confirmar Contraseña")
            {
                allInfo = false;
                lblMissingInfo.Text = "Por favor complete todos los campos";
                lblMissingInfo.ForeColor = Color.Red;
            }

            bool validEmail = CheckEmail(email);
            if (!validEmail)
            {
                lblSignupWrongEmail.ForeColor = Color.Red;
            } else
            {
                lblSignupWrongEmail.ForeColor = Color.Transparent;
            }

            bool validPwd = true;

            if (pwd != pwd2)
            {
                validPwd = false;
                lblSignupWrongPwd.ForeColor = Color.Red;
            } else
            {
                lblSignupWrongPwd.ForeColor = Color.Transparent;
            }

            if (allInfo && validEmail && validPwd)
            {
                System.Diagnostics.Debug.WriteLine("XD");

                User newUser = new (username, pwd, email);
                Program.userList.Add(newUser);

                string message = "¡Cuenta Creada! Ahora puede iniciar sesión";
                string caption = "Registro";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    Login login = new Login();

                    this.Hide();
                    login.Show();
                }

            }
            else
            {
                System.Diagnostics.Debug.WriteLine("XDn't");
            }
        }

        /*
         * BTN CANCEL
         */
        private void txtSignupCancel_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            this.Hide();
            login.Show();
        }

        /*
         * TXT USER
         */
        private void txtSignupUser_Enter(object sender, EventArgs e)
        {
            if (txtSignupUser.Text == "Usuario")
            {
                txtSignupUser.Text = "";
                txtSignupUser.ForeColor = Color.Black;
            }
        }

        private void txtSignupUser_Leave(object sender, EventArgs e)
        {
            if (txtSignupUser.Text == "")
            {
                txtSignupUser.Text = "Usuario";
                txtSignupUser.ForeColor = Color.LightGray;
            }
        }
        /*
         * TXT EMAIL
         */
        private void txtSignupEmail_Enter(object sender, EventArgs e)
        {
            if (txtSignupEmail.Text == "E-Mail")
            {
                txtSignupEmail.Text = "";
                txtSignupEmail.ForeColor = Color.Black;
            }
        }

        private void txtSignupEmail_Leave(object sender, EventArgs e)
        {
            if (txtSignupEmail.Text == "")
            {
                txtSignupEmail.Text = "E-Mail";
                txtSignupEmail.ForeColor = Color.LightGray;
            }
        }
        /*
         * TXT PASSWORD
         */
        private void txtSignupPwd_Enter(object sender, EventArgs e)
        {
            if (txtSignupPwd.Text == "Contraseña")
            {
                txtSignupPwd.Text = "";
                txtSignupPwd.ForeColor = Color.Black;
            }
        }

        private void txtSignupPwd_Leave(object sender, EventArgs e)
        {
            if (txtSignupPwd.Text == "")
            {
                txtSignupPwd.Text = "Contraseña";
                txtSignupPwd.ForeColor = Color.LightGray;
            }
        }
        /*
         * TXT PASSWORD 2
         */
        private void txtSignupPwd2_Enter(object sender, EventArgs e)
        {
            if (txtSignupPwd2.Text == "Confirmar Contraseña")
            {
                txtSignupPwd2.Text = "";
                txtSignupPwd2.ForeColor = Color.Black;
            }
        }

        private void txtSignupPwd2_Leave(object sender, EventArgs e)
        {
            if (txtSignupPwd2.Text == "")
            {
                txtSignupPwd2.Text = "Confirmar Contraseña";
                txtSignupPwd2.ForeColor = Color.LightGray;
            }
        }
    }
}
