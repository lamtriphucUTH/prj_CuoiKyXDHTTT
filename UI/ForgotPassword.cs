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
using prj_CuoiKyXDHTTT.Data;

namespace prj_CuoiKyXDHTTT.UI
{
    public partial class ForgotPassword : Form
    {
        private readonly UserDAL _userDAL;

        public ForgotPassword()
        {
            InitializeComponent();
            _userDAL = new UserDAL();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUid.Text.Trim();
            string hint = txtHint.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(hint))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            string password = _userDAL.GetPasswordByHint(username, hint);

            if (password != null)
            {
                txtpass.Text = password;
            }
            else
            {
                MessageBox.Show("Không tìm thấy mật khẩu. Vui lòng kiểm tra lại Username và Hint", "Thông báo");
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