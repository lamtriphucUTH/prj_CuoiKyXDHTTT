using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_CuoiKyXDHTTT
{
    public partial class AdminHomepage: Form
    {
        private string connStr = "Data Source=.;Initial Catalog=MobileShoppe;Integrated Security=True";
        public AdminHomepage()
        {
            InitializeComponent();
        }
        private void AdminHomepage_Load(object sender, EventArgs e)
        {
            InitCompanyTab();
            InitModelTab();
            InitMobileTab();
        }
        private void tabControlAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlAdd.SelectedTab == tabAddCompany)
            {
            }
            else if (tabControlAdd.SelectedTab == tabAddModel)
            {
            }
            else if (tabControlAdd.SelectedTab == tabAddMobile)
            {
            }
        }
        #region COMMON
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connStr);
        }
        private string GetNextId(string tableName, string colName)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(
                $"SELECT MAX(CAST({colName} AS INT))+1 FROM {tableName}", conn);
            
            conn.Open();
            var obj = cmd.ExecuteScalar();
            conn.Close();

            if (obj == DBNull.Value || obj == null)
                return "0";
            else 
                return obj.ToString();
        }
        #endregion
        #region ADD COMPANY
        private void InitCompanyTab()
        {
            txtComId.Text = GetNextId("tbl_Company", "ComId");
            txtComId.Enabled = false;
            txtComName.Clear();
        }
        private void btnAddCom_Click(object sender, EventArgs e)
        {
            string newId = txtComId.Text.Trim();
            string name = txtComName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Nhập tên công ty!");
                return;
            }

            const string sql = "INSERT INTO tbl_Company (ComId, CName) VALUES (@id, @name)";
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar, 50) { Value = newId });
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 100) { Value = name });

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm Company thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InitCompanyTab();  // refresh lại dữ liệu trên UI
                    }
                    else
                    {
                        MessageBox.Show("Không có công ty nào được thêm.", "Chưa thêm được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL (trùng key, lỗi kết nối, ...)
                MessageBox.Show($"Lỗi khi thêm công ty:\n{ex.Message}", "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Bắt các lỗi khác
                MessageBox.Show($"Đã có lỗi xảy ra:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        #endregion
        #region ADD MODEL
        private void InitModelTab()
        {
            // load combobox công ty
            cbComName_Model.Items.Clear();
            foreach (string c in GetCompanyNames()) cbComName_Model.Items.Add(c);

            txtModelId.Text = GetNextId("tbl_Model", "ModelId");
            txtModelId.Enabled = false;
            txtModelNum.Clear();
            cbComName_Model.SelectedIndex = -1;
        }
        private List<string> GetCompanyNames()
        {
            var companyNames = new List<string>();
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT CName FROM tbl_Company";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                        companyNames.Add(rd["CName"].ToString());
                }
            }
            return companyNames;
        }
        private int? GetCompanyIdByName(string name)
        {
            int? comId = null;
            using (var conn = GetConnection()) 
            {
                string query = "SELECT ComId FROM tbl_Company WHERE CName=@name";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result == null) return null;
                    comId = int.Parse(result.ToString());
                }
            }
            return comId;
        }
        private void btnAddModel_Click(object sender, EventArgs e)
        {
            if (cbComName_Model.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtModelNum.Text))
            {
                MessageBox.Show("Chọn Company và nhập ModelNum!");
                return;
            }
            string id = txtModelId.Text.Trim();
            string num = txtModelNum.Text.Trim();
            int? comId = GetCompanyIdByName(cbComName_Model.SelectedItem.ToString());
            if (comId == null)
            {
                MessageBox.Show("Company không hợp lệ!");
                return;
            }
            using (var conn = GetConnection())
            {
                string query = "INSERT INTO tbl_Model (ModelId, ComId, ModelNum, AvailableQty) VALUES(@id,@comid,@num,0)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@comid", comId.Value);
                    cmd.Parameters.AddWithValue("@num", num);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Thêm Model thành công!");
            InitModelTab();
        }
        #endregion
        #region ADD MOBILE
        private void InitMobileTab()
        {
            // load companies cho mobile
            cbComName_Mobile.Items.Clear();
            foreach (var c in GetCompanyNames()) 
                cbComName_Mobile.Items.Add(c);

            cbModelNum_Mobile.Items.Clear();
            cbModelNum_Mobile.Enabled = false;

            txtIMEINO.Clear();
            txtPrice.Clear();
            cbWarranty.SelectedIndex = -1;
            //btnAddMobile.Enabled = false;
        }
        private List<string> GetModelNameByCompany(int comId)
        {
            List<string> modelNames = new List<string>();
            using (var conn = GetConnection())
            {
                string query = "SELECT ModelNum FROM tbl_Model WHERE ComId=@cid";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cid", comId);
                    conn.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                        modelNames.Add(rd["ModelNum"].ToString());
                }
            }
            return modelNames;
        }
        private void cbComName_Mobile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbComName_Mobile.SelectedItem == null)
            {
                cbModelNum_Mobile.Items.Clear();
                cbModelNum_Mobile.Enabled = false;
                return;
            }

            int? cid = GetCompanyIdByName(cbComName_Mobile.SelectedItem.ToString());
            if (cid == null) return;

            var models = GetModelNameByCompany(cid.Value);
            cbModelNum_Mobile.Items.Clear();
            foreach (var model in models)
                cbModelNum_Mobile.Items.Add(model);

            cbModelNum_Mobile.Enabled = true;
            cbModelNum_Mobile.SelectedIndex = -1;
        }
        private void TxtIMEINO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private DateTime CalculateWarrantyExpiry(string period)
        {
            var today = DateTime.Now.Date;
            switch (period)
            {
                case "3 months": return today.AddMonths(3);
                case "6 months": return today.AddMonths(6);
                case "1 year": return today.AddYears(1);
                case "2 years": return today.AddYears(2);
                default: throw new ArgumentException("Warranty không hợp lệ");
            }
        }
        private void btnAddMobile_Click(object sender, EventArgs e)
        {
            if (cbModelNum_Mobile.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtIMEINO.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                cbWarranty.SelectedItem == null)
            {
                MessageBox.Show("Nhập đầy đủ thông tin Mobile!");
                return;
            }
            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Giá phải là số!");
                return;
            }
            DateTime expiry;
            try { 
                expiry = CalculateWarrantyExpiry(cbWarranty.SelectedItem.ToString()); 
            }
            catch { 
                MessageBox.Show("Chọn Warranty!"); return; 
            }

            int? modelId = GetModelIdByNum(cbModelNum_Mobile.SelectedItem.ToString());

            using (var conn = GetConnection())
            {
                string query = "INSERT INTO tbl_Mobile (ModelId, IMEINO, Status, Warranty, Price) " +
                    "VALUES(@mid,@imei,'Available',@w,@p)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@mid", modelId);
                    cmd.Parameters.AddWithValue("@imei", txtIMEINO.Text.Trim());
                    cmd.Parameters.AddWithValue("@w", expiry);
                    cmd.Parameters.AddWithValue("@p", price);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Thêm Mobile thành công!");
                InitMobileTab();
            }
        }
        private int? GetModelIdByNum(string modelNum)
        {
            int? modelId = null;
            using (var conn = GetConnection())
            {
                string query = "SELECT ModelId FROM tbl_Model WHERE ModelNum=@modelnum";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@modelnum", modelNum);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result == null) return null;
                    modelId = int.Parse(result.ToString());
                }
            }
            return modelId;
        }
        #endregion
    }
}
