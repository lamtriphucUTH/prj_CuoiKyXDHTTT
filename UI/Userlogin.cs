using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prj_CuoiKyXDHTTT.UI;

namespace prj_CuoiKyXDHTTT
{
    public partial class Userlogin : Form
    {
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
    }
}
