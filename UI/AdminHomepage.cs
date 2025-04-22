using prj_CuoiKyXDHTTT.Data;
using prj_CuoiKyXDHTTT.DTO;
using prj_CuoiKyXDHTTT.Helpers;
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

namespace prj_CuoiKyXDHTTT.UI
{
    public partial class AdminHomepage: Form
    {
        CompanyDAL companyDAL = new CompanyDAL();
        ModelDAL modelDAL = new ModelDAL();

        public AdminHomepage()
        {
            InitializeComponent();
        }
        private void AdminHomepage_Load(object sender, EventArgs e)
        {
            LoadAddCompanyUI();
        }
        private void tabControlAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlAdd.SelectedTab == tabAddCompany)
            {
                LoadAddCompanyUI();
            }
            else if (tabControlAdd.SelectedTab == tabAddModel)
            {
                LoadAddModelUI();
            }
        }

        #region Company
        private void LoadAddCompanyUI()
        {
            txtComId.Text = IdGenerator.GenerateNextId("tbl_Company", "ComId").ToString();
            txtComId.Enabled = false;
        }


        private void btnAddCom_Click(object sender, EventArgs e)
        {
            //int newId = IdGenerator.GenerateNextId("tbl_Company", "ComId");
            int newId = int.Parse(txtComId.Text);

            CompanyDTO company = new CompanyDTO
            {
                ComId = newId,
                CName = txtComName.Text.Trim()
            };

            bool success = companyDAL.AddCompany(company);

            if (success)
            {
                MessageBox.Show("Thêm công ty thành công!");
                LoadAddCompanyUI();
                txtComName.Clear();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }

        }
        #endregion

        #region Model
        private void LoadAddModelUI()
        {
            LoadCompanyNames();
            txtModelId.Text = IdGenerator.GenerateNextId("tbl_Model", "ModelId").ToString();
            txtModelId.Enabled = false;
        }

        private void LoadCompanyNames()
        {
            cbComName_Model.Items.Clear();
            List<string> companyNames = companyDAL.GetCompanyNames();

            foreach (string name in companyNames)
            {
                cbComName_Model.Items.Add(name);
            }
        }
        private void btnAddModel_Click(object sender, EventArgs e)
        {
            if (cbComName_Model.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tên công ty!");
                return;
            }
            string companyName = cbComName_Model.SelectedItem.ToString();
            int? comId = companyDAL.GetCompanyIdByName(companyName);

            if (comId == null)
            {
                MessageBox.Show("Không tìm thấy công ty!");
                return;
            }

            ModelDTO model = new ModelDTO
            {
                ModelId = int.Parse(txtModelId.Text.Trim()),
                Company = new CompanyDTO
                {
                    ComId = comId.Value,
                    CName = companyName
                },
                ModelNum = txtModelNum.Text.Trim()
            };

            bool success = modelDAL.AddModel(model);
            if (success)
            {
                MessageBox.Show("Thêm mẫu thành công!");
                LoadAddModelUI();
                txtModelNum.Clear();
                cbComName_Model.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
        #endregion
    }
}
