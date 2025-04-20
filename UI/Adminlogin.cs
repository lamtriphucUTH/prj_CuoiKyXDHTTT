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
   
        }
    }
}
