﻿using System;
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
    public partial class UserLogin : Form
    {
        UserDAL userDAL = new UserDAL();

        public UserLogin()
        {
            InitializeComponent();
        }
        private void UserLogin_Load(object sender, EventArgs e)
        {

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

            UserDTO user = userDAL.Login(username, password);

            if (user != null)
            {
                UserHomepage userHomepage = new UserHomepage();
                this.Hide();
                userHomepage.ShowDialog();
                this.Show();
            }
        }

        private void lnkToAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogin objLogin = new AdminLogin();
            objLogin.Show();
            this.Hide();
        }
    }
}
