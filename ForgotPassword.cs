using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_CuoiKyXDHTTT
{
    public partial class ForgotPassword : Form
    {
        private string connStr = "Data Source=.;Initial Catalog=MobileShoppe;Integrated Security=True";
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUid.Text.Trim();
            string hint = txtHint.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (username.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Không được phép nhập tài khoản admin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUid.Text = "";
                txtUid.Focus();
                return;
            }
            if (string.IsNullOrEmpty(hint))
            {
                MessageBox.Show("Vui lòng nhập gợi ý.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string password = GetPasswordByHint(username, hint);
            if (password != null)
            {
                txtpass.Text = password;
                txtpass.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản phù hợp hoặc gợi ý sai.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Text = string.Empty;
            }
        }
        private string GetPasswordByHint(string username, string hint)
        {
            const string sql = @"SELECT PWD FROM tbl_User WHERE UserName = @username AND Hint = @hint";

            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@hint", hint);

                conn.Open();
                var result = cmd.ExecuteScalar();
                return (result == null || result == DBNull.Value)
                    ? null
                    : result.ToString();
            }
        }

        private void lblLoginpage_Click(object sender, EventArgs e)
        {
            // Thay thế bằng form đăng nhập của bạn
            UserLogin loginForm = new UserLogin();
            loginForm.Show();
            this.Hide();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            // Ẩn password khi chưa tìm thấy
            txtpass.Text = "";
        }
    }
}