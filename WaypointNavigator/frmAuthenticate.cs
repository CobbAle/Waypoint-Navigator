using System;
using System.Linq;
using System.Windows.Forms;

namespace WaypointNavigator
{
    public partial class LoginRegister : Form
    {
        public LoginRegister()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool validLogin = false;
            User AccessedUser = new User();

            if (tbxEmailAddress.Text.Contains("@")) //EmailAddressorUsername | EmailAddress
            {
                AccessedUser.Email = tbxEmailAddress.Text;
                AccessedUser.NameFromEmail(AccessedUser.Email);
            }

            if (AccessedUser.FirstName != null)
            {
                AccessedUser.Password = tbxPassword.Text;
                AccessedUser.Password = AccessedUser.hashPassword();

                validLogin = emailValidation(tbxEmailAddress.Text);
                validLogin = AccessedUser.checkLogin(tbxEmailAddress.Text, AccessedUser.Password);
            }

            if (validLogin == false)
            {
                MessageBox.Show("Failed Login! Please enter a valid username or password.",
                    "Waypoint Navigator Login", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Successful Login", "Waypoint Navigator Login", MessageBoxButtons.OK);
                AccessedUser.FillUserDetails();
                
                frmMainApplication AccessedForm = new frmMainApplication(AccessedUser);
                AccessedForm.Show();
                this.Hide();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            pnlRegister.Show();
            pnlLogin.Hide();
            tbxEmailRegister.Text = tbxEmailAddress.Text; //Needs to check for @symbol then send to correct box.
            tbxPasswordRegister.Text = tbxPassword.Text;
            
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            bool valid = true;
            User newUser = new User();

            if ((tbxEmailRegister.Text == "" ||
                tbxFirstNameRegister.Text == "" || tbxLastNameRegister.Text == "" ||
                tbxPasswordRegister.Text == "" || tbxPasswordReenter.Text == "") == false)
            {
                //valid = passwordVerification();
            }
            else
            {
                MessageBox.Show("Failed to generate account. Please make sure to fill in all details",
                    "Waypoint Navigator Login", MessageBoxButtons.OK);
                valid = false;

            } //If statement to check if all details are filled in.

            if (valid)

            {
                newUser.FirstName = tbxFirstNameRegister.Text;
                newUser.LastName = tbxLastNameRegister.Text;
                newUser.Email = tbxEmailRegister.Text;
                newUser.Password = tbxPasswordRegister.Text;

                newUser.RegisterUser();
            }

            frmMainApplication AccessedForm = new frmMainApplication(newUser);
            AccessedForm.Show();
            this.Hide();

        }

        private bool emailValidation(string emailAddress)
        {
            string[] emailEndings = { ".co", ".com", ".gov", ".edu", ".org", ".net", ".int", ".mil" };
            bool valid;

            valid = (emailAddress.Contains(emailAddress) && emailEndings.Contains("@"));
            
            return valid;
        }

        private void tbxPasswordReenter_TextChanged(object sender, EventArgs e)
        {
            if (tbxPasswordReenter.Text == tbxPasswordRegister.Text)
            {
                lblPasswordMatch.Hide();
            }
            else
            {
                lblPasswordMatch.Show();
            }
        }

    }
}
