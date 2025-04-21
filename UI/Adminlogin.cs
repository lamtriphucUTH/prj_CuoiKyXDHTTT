using prj_CuoiKyXDHTTT.Data;
using prj_CuoiKyXDHTTT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_CuoiKyXDHTTT.UI
{
    public partial class Adminlogin : Form
    {
        UserDAL userDAL = new UserDAL();
        public Adminlogin()
        {
            InitializeComponent();
        }

        private void linkBack_linkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Userlogin objLogin = new Userlogin();
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

            User user = userDAL.Login(username, password);

            if (user != null)
            {
                MessageBox.
                    Show(user.EmployeeName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Adminlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
