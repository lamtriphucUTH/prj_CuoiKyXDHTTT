﻿using System;
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
    public partial class UserLogin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=MobileShoppe;Integrated Security=True");

        public UserLogin()
        {
            InitializeComponent();
        }
        private void UserLogin_Load(object sender, EventArgs e)
        {
            txtPwd.UseSystemPasswordChar = true;
        }

        private void linklabel_linkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogin objLogin = new AdminLogin();
            objLogin.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPwd.Text.Trim();

            // Kiểm tra nếu username chứa "admin" (không phân biệt hoa thường)
            if (username.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Vui lòng sử dụng trang đăng nhập Admin để đăng nhập tài khoản admin.",
                              "Không thể đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng xử lý tiếp
            }

            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_User WHERE UserName = @username AND PWD = @password", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    UserHomepage userHomepage = new UserHomepage();
                    this.Hide();
                    userHomepage.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu hoặc tài khoản không tồn tại.",
                                  "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void lnkToAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogin objLogin = new AdminLogin();
            this.Hide();
            objLogin.Show();
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword objForgotPass = new ForgotPassword();
            objForgotPass.Show();
            this.Hide();
        }


        private void picShowHide_Click(object sender, EventArgs e)
        {
            bool isHiden = txtPwd.UseSystemPasswordChar;
            txtPwd.UseSystemPasswordChar = !isHiden;

            if (!isHiden)
            {
                //picShowHide.Image = Image.FromFile("eye_closed.png");
                picShowHide.Image = Properties.Resources.eye_closed;
            }
            else
            {
                //picShowHide.Image = Image.FromFile("eye_open.png");
                picShowHide.Image = Properties.Resources.eye_open;
            }
        }
    }
}
