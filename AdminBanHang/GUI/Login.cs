using System;
using System.Windows.Forms;
using AdminBanHang.BLL;
namespace AdminBanHang.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (!username.Equals("") && !password.Equals(""))
            {
                EmployeeBLL employeeBLL = new EmployeeBLL();
                if (employeeBLL.Login(username, password))
                {
                    Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                else
                    MessageBox.Show("Username or Password incorrect", "Login unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Username or Password empty", "Error login", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
