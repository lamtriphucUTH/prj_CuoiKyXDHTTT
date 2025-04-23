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
        MobileDAL mobileDAL = new MobileDAL();

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
            else if (tabControlAdd.SelectedTab == tabAddMobile)
            {
                LoadAddMobileUI();
            }
        }
        private void LoadCompanyNames(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            List<string> companyNames = companyDAL.GetCompanyNames();

            foreach (string name in companyNames)
            {
                comboBox.Items.Add(name);
            }
        }
        private void LoadAddModelNames()
        {
            cbModelNum_Mobile.Items.Clear();
            List<string> modelNumbers = modelDAL.GetModelNumbers();

            foreach (string number in modelNumbers)
            {
                cbModelNum_Mobile.Items.Add(number);
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
            LoadCompanyNames(cbComName_Model);
            txtModelId.Text = IdGenerator.GenerateNextId("tbl_Model", "ModelId").ToString();
            txtModelId.Enabled = false;
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

        #region Mobile
        private void LoadAddMobileUI()
        {
            LoadCompanyNames(cbComName_Mobile);
            LoadAddModelNames();
        }
        private void btnAddMobile_Click(object sender, EventArgs e)
        {
            if (cbComName_Mobile.SelectedIndex < 0
                 || cbModelNum_Mobile.SelectedIndex < 0
                 || string.IsNullOrWhiteSpace(txtIMEINO.Text)
                 || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thiếu dữ liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Giá phải là số hợp lệ.", "Lỗi định dạng",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Tính thời gian hết hạn bảo hành
            DateTime warrantyExpiry;
            try
            {
                warrantyExpiry = CalculateWarrantyExpiry(cbWarranty.SelectedItem.ToString());
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int? modelId = modelDAL.GetModelIdByNumber(cbModelNum_Mobile.SelectedItem.ToString());
            if (modelId == null)
            {
                MessageBox.Show("Không tìm thấy mẫu điện thoại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MobileDTO mobile = new MobileDTO
            {
                
                Model = new ModelDTO
                {
                    ModelId = modelId.Value,
                    ModelNum = cbModelNum_Mobile.SelectedItem.ToString()
                },
                IMEINO = txtIMEINO.Text.Trim(),
                Status = "Available",
                Warranty = warrantyExpiry,
                Price = price
            };
            bool success = mobileDAL.AddMobile(mobile);
            if (success)
            {
                MessageBox.Show("Thêm mobile thành công!", "Thành công",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Reset
                cbComName.SelectedIndex = -1;
                cbModelNum.DataSource = null;
                txtIMEINO.Clear();
                txtPrice.Clear();
                btnAddMobile.Enabled = false;
            }
            else
            {
                MessageBox.Show("Thêm thất bại. Kiểm tra lại.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DateTime CalculateWarrantyExpiry(string period)
        {
            DateTime today = DateTime.Now.Date;
            switch (period)
            {
                case "3 months":
                    return today.AddMonths(3);
                case "6 months":
                    return today.AddMonths(6);
                case "1 year":
                    return today.AddYears(1);
                case "2 years":
                    return today.AddYears(2);
                default:
                    throw new ArgumentException("Warranty period không hợp lệ");
            }
        }


        #endregion

        private void cbComName_Mobile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
