using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_CuoiKyXDHTTT
{
    public partial class UserHomepage : Form
    {
        private string connStr = "Data Source=.;Initial Catalog=MobileShoppe;Integrated Security=True";
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connStr);
        }
        public UserHomepage()
        {
            InitializeComponent();
        }

        private void UserHomepage_Load(object sender, EventArgs e)
        {
            LoadViewStock();
            LoadSales();
        }
        private void LoadViewStock()
        {
            GetCompanyNames(cbCompanyName_ViewStock);
            cbModelNumber_ViewStock.Enabled = false;
            txtStockAvailable.ReadOnly = true;
        }
        private void GetCompanyNames(ComboBox comboBox)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT CName FROM tbl_Company";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        comboBox.Items.Add(rd["CName"]);
                    }
                }
            }
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
        private int? GetModelIdByNum(string modelNum)
        {
            int? modelId = null;
            using (var conn = GetConnection())
            {
                string query = "SELECT ModelId FROM tbl_Model WHERE ModelNum=@modelNum";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@modelNum", modelNum);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result == null) return null;
                    modelId = int.Parse(result.ToString());
                }
            }
            return modelId;
        }
        private void GetModelNameByCompany(int comId, ComboBox comboBox)
        {
            using (var conn = GetConnection())
            {
                string query = "SELECT ModelNum FROM tbl_Model WHERE ComId=@cid";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cid", comId);
                    conn.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                        comboBox.Items.Add(rd["ModelNum"].ToString());
                }
            }
        }

        private void cbCompanyName_ViewStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbModelNumber_ViewStock.Text = string.Empty;
            if (cbCompanyName_ViewStock.SelectedItem == null)
            {
                cbModelNumber_ViewStock.Items.Clear();
                cbModelNumber_ViewStock.Enabled = false;
                return;
            }
            int? cid = GetCompanyIdByName(cbCompanyName_ViewStock.SelectedItem.ToString());
            if (cid == null) return;

            GetModelNameByCompany(cid.Value, cbModelNumber_ViewStock);
            cbModelNumber_ViewStock.Items.Clear();

            cbModelNumber_ViewStock.Enabled = true;
            cbModelNumber_ViewStock.SelectedIndex = -1;

            
        }
        private void LoadStockAvailable(string modelNum)
        {
            string sql = "SELECT AvailableQty FROM tbl_Model WHERE ModelNum = @modelNum";
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@modelNum", modelNum);
                conn.Open();
                object result = cmd.ExecuteScalar();
                txtStockAvailable.Text = result != null ? result.ToString() : "0";
            }
        }

        private void cbModelNumber_ViewStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            string modelNum = cbModelNumber_ViewStock.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(modelNum))
            {
                LoadStockAvailable(modelNum);
            }
        }
        #region Search IMEI Number
        private void lnkSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string imei = txtIMEINumber.Text.Trim();
            if (string.IsNullOrEmpty(imei))
            {
                MessageBox.Show("Vui lòng nhập số IMEI.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = GetConnection())
            {
                string query = @"
            SELECT c.CustName, c.MobileNumber, c.EmailId, c.Address
            FROM tbl_Customer c
            JOIN tbl_Sales s ON c.CusId = s.CusId
            WHERE s.IMEINO = @imei";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@imei", imei);
                    conn.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dtgvSearchResult.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy khách hàng với IMEI này.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        #endregion
        #region Sale
        private void LoadSales()
        {
            GetCompanyNames(cbCompanyName);
            cbModelNumber.Enabled = false;
            cbIMEINumber.Enabled = false;
            txtPricePerPiece.ReadOnly = true;
        }
        private void cbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbModelNumber.Text = string.Empty;
            if (cbCompanyName.SelectedItem == null)
            {
                cbModelNumber.Items.Clear();
                cbModelNumber.Enabled = false;
                return;
            }
            int? cid = GetCompanyIdByName(cbCompanyName.SelectedItem.ToString());
            if (cid == null) return;

            cbModelNumber.Items.Clear();
            GetModelNameByCompany(cid.Value, cbModelNumber);

            cbModelNumber.Enabled = true;
            cbModelNumber.SelectedIndex = -1;
        }
        private void cbModelNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIMEINumber.Text = string.Empty;
            if (cbModelNumber.SelectedItem == null)
            {
                cbIMEINumber.Items.Clear();
                cbIMEINumber.Enabled = false;
                return;
            }
            int? modelId = GetModelIdByNum(cbModelNumber.SelectedItem.ToString());
            if (modelId == null) return;

            cbIMEINumber.Items.Clear();

            string query = "SELECT IMEINO FROM tbl_Mobile WHERE ModelId = @modelId AND Status = 'Not Sold'";
            
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@modelId", modelId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbIMEINumber.Items.Add(reader["IMEINO"].ToString());
                    }
                }
            }
            cbIMEINumber.Enabled = true;
            cbIMEINumber.SelectedIndex = -1;
        }
        private void cbIMEINumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedIMEI = cbIMEINumber.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedIMEI)) return;

            string query = "SELECT Price FROM tbl_Mobile WHERE IMEINO = @imei";

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@imei", selectedIMEI);
                conn.Open();
                object result = cmd.ExecuteScalar();
                txtPricePerPiece.Text = result != null ? result.ToString() : string.Empty;
            }
        }

        #endregion

        // Check Customer and view confirm details
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateCustomerInfo()) return;

            ConfirmDetails confirmForm = new ConfirmDetails(
                txtCustomerName.Text,
                txtMobileNumber.Text,
                txtAddress.Text,
                txtEmail.Text,
                cbCompanyName.Text,
                cbModelNumber.Text,
                cbIMEINumber.Text,
                txtPricePerPiece.Text
            );

            confirmForm.ShowDialog();
        }
        private bool ValidateCustomerInfo()
        {
            // Validate Tên
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                !Regex.IsMatch(txtCustomerName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Tên khách hàng chỉ được chứa chữ cái.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate SĐT
            if (!Regex.IsMatch(txtMobileNumber.Text, @"^\d{10,12}$"))
            {
                MessageBox.Show("Số điện thoại phải có từ 10 đến 12 chữ số.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate Email
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không đúng định dạng.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

    }
}
