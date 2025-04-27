using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_CuoiKyXDHTTT
{
    public partial class AdminLogin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=MobileShoppe;Integrated Security=True");
        public AdminLogin()
        {
            InitializeComponent();
        }
        private void Adminlogin_Load(object sender, EventArgs e)
        {
            txtPwd.UseSystemPasswordChar = true;
        }

        private void linkBack_linkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserLogin objLogin = new UserLogin();
            objLogin.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPwd.Text.Trim();

            if (username != "admin")
            {
                MessageBox.Show("Đây không phải tài khoản Admin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_User WHERE UserName = @username AND PWD = @password", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                AdminHomepage adminHomepage = new AdminHomepage();
                this.Hide();
                adminHomepage.ShowDialog();
                this.Show();
            } else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản không tồn tại.",
                                "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword objForgotPass = new ForgotPassword();
            objForgotPass.Show();
            this.Hide();
        }
        
        private bool isPasswordShown = false;

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (isPasswordShown)
            {
                txtPwd.UseSystemPasswordChar = true;
                btnShowHide.Text = "Hiện";
                isPasswordShown = false;
            }
            else
            {
                txtPwd.UseSystemPasswordChar = false;
                btnShowHide.Text = "Ẩn";
                isPasswordShown = true;
            }
        }
    }
}
