using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prj_CuoiKyXDHTTT.Data;
using prj_CuoiKyXDHTTT.DTO;
using prj_CuoiKyXDHTTT.UI;

namespace prj_CuoiKyXDHTTT
{
    public partial class Userlogin : Form
    {
        UserDAL userDAL = new UserDAL();

        public Userlogin()
        {
            InitializeComponent();
        }

        private void linklabel_linkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Adminlogin objLogin = new Adminlogin();
            objLogin.Show();
            this.Hide();
        }

        private void Userlogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPwd.Text.Trim();

            User user = userDAL.Login(username, password);

            if (user != null)
            {
                UserHomepage objHomepage = new UserHomepage();
                this.Hide();
                objHomepage.ShowDialog();
                this.Show();
            }
        }
    }
}
