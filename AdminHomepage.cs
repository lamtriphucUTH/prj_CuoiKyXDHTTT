using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office.Word;

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
            InitUpdateStock();
            dtpSelectDay.Value = DateTime.Today;
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
            cbComName_Mobile.SelectedIndex = -1;
            cbComName_Mobile.Items.Clear();
            cbModelNum_Mobile.Text = string.Empty;

            // load companies cho mobile
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
            // 1. Kiểm tra modelId có hợp lệ không
            if (modelId == null)
            {
                MessageBox.Show("Model không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Kiểm tra model đã nhập kho chưa
            int importedQty = GetImportedQuantity(modelId.Value);
            int existingMobiles = GetNotSoldMobilesCount(modelId.Value);

            if (importedQty <= existingMobiles)
            {
                MessageBox.Show("Model này chưa được nhập sản phẩm mới! Vui lòng nhập kho trước.",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = GetConnection())
            {
                string query = "INSERT INTO tbl_Mobile (ModelId, IMEINO, Status, Warranty, Price) " +
                    "VALUES(@mid,@imei,'Not Sold',@w,@p)";
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
        private int GetImportedQuantity(int modelId)
        {
            int total = 0;
            using (var conn = GetConnection())
            {
                string query = "SELECT SUM(AvailableQty) FROM tbl_Model WHERE ModelId = @mid";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@mid", modelId);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                        total = Convert.ToInt32(result);
                }
            }
            return total;
        }
        private int GetNotSoldMobilesCount(int modelId)
        {
            int count = 0;
            using (var conn = GetConnection())
            {
                string query = "SELECT COUNT(*) FROM tbl_Mobile WHERE ModelId = @mid AND Status = 'Not Sold'";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@mid", modelId);
                    conn.Open();
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return count;
        }


        #endregion
        #region ADD EMPLOYEE
        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string name = txtEployeeName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string phone = txtMobile.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPass.Text;
            string retype = txtRetypePass.Text;
            string hint = txtHint.Text.Trim();

            // 1. Kiểm tra required
            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(retype) ||
                string.IsNullOrEmpty(hint))
            {
                MessageBox.Show("Vui lòng điền đầy đủ tất cả các trường.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra độ dài phone
            if (phone.Length < 10 || phone.Length > 12)
            {
                MessageBox.Show("Số điện thoại phải có từ 10 đến 12 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Username: duy nhất, >=6 ký tự, ít nhất 1 chữ và 1 số
            if (username.Length < 6 ||
                !Regex.IsMatch(username, @"[A-Za-z]") ||
                !Regex.IsMatch(username, @"\d"))
            {
                MessageBox.Show("Username phải có ít nhất 6 ký tự, chứa ít nhất 1 chữ cái và 1 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UsernameExists(username))
            {
                MessageBox.Show("Username này đã tồn tại. Vui lòng chọn tên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Password: >=8 ký tự, bắt đầu bằng chữ in hoa, ít nhất 1 số, 1 ký tự đặc biệt
            if (password.Length < 8 ||
                !Regex.IsMatch(password, @"^[A-Z]") ||
                !Regex.IsMatch(password, @"\d") ||
                !Regex.IsMatch(password, @"[\W_]"))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự, bắt đầu bằng chữ in hoa, chứa ít nhất 1 chữ số và 1 ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Re‑type password
            if (password != retype)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 6. Hint: >=5 ký tự
            if (hint.Length < 5)
            {
                MessageBox.Show("Hint phải có ít nhất 5 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            const string sql = @"
                INSERT INTO tbl_User
                (EmployeeName, Address, MobileNumber, Username, PWD, Hint)
                VALUES (@name, @address, @phone, @username, @pwd, @hint)";
            try
            {
                // Mình khuyến cáo lưu hash của password, không lưu plain-text

                using (var conn = GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@pwd", password);
                    cmd.Parameters.AddWithValue("@hint", hint);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Thêm nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Chưa có nhân viên nào được thêm.", "Chưa thêm được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi cơ sở dữ liệu:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private bool UsernameExists(string username)
        {
            const string sql = "SELECT COUNT(1) FROM tbl_User WHERE Username = @username";
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                conn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }
        private void ClearForm()
        {
            txtEployeeName.Clear();
            txtAddress.Clear();
            txtMobile.Clear();
            txtUsername.Clear();
            txtPass.Clear();
            txtRetypePass.Clear();
            txtHint.Clear();
        }
        #endregion
        #region UPDATE STOCK
        private void InitUpdateStock()
        {
            cbComName.SelectedIndex = -1;
            //cbModelNum.SelectedIndex = -1;
            cbModelNum.Text = string.Empty;

            txtTransId.Text = GetNextId("tbl_Transaction", "TransId");
            txtTransId.Enabled = false;

            // load companies cho Update stock
            cbComName.Items.Clear();
            foreach (var c in GetCompanyNames())
                cbComName.Items.Add(c);

            cbModelNum.Items.Clear();
            cbModelNum.Enabled = false;

            txtQuantity.Clear();
            txtAmount.Clear();

        }
        private void cbComName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbComName.SelectedItem == null)
            {
                cbModelNum.Items.Clear();
                cbModelNum.Enabled = false;
                return;
            }

            int? cid = GetCompanyIdByName(cbComName.SelectedItem.ToString());
            if (cid == null) return;

            var models = GetModelNameByCompany(cid.Value);
            cbModelNum.Items.Clear();
            foreach (var model in models)
                cbModelNum.Items.Add(model);

            cbModelNum.Enabled = true;
            cbModelNum.SelectedIndex = -1;
        }
        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            if (cbModelNum.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Nhập đầy đủ thông tin để Cập nhật!");
                return;
            }
            if ((!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount)) ||
                (!decimal.TryParse(txtQuantity.Text.Trim(), out decimal quantity)))
            {
                MessageBox.Show("Giá và số lượng phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int? modelId = GetModelIdByNum(cbModelNum.SelectedItem.ToString());
            if (modelId == null)
            {
                MessageBox.Show("Model không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            using (SqlConnection conn = GetConnection())
            {
                DateTime now = DateTime.Now.Date;
                string query = "INSERT INTO tbl_Transaction (TransId, ModelId, Quantity, Date, Amount) " +
                    "VALUES(@transid,@modelid,@qty,@date,@amt)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@transid", txtTransId.Text.Trim());
                    cmd.Parameters.AddWithValue("@modelid", modelId);
                    cmd.Parameters.AddWithValue("@qty", quantity);
                    cmd.Parameters.AddWithValue("@date", now);
                    cmd.Parameters.AddWithValue("@amt", amount);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                // Sau khi thêm transaction
                // Cập nhật AvailableQty trong tbl_Model
                string updateQtyQuery = "UPDATE tbl_Model SET AvailableQty = ISNULL(AvailableQty, 0) + @qty WHERE ModelId = @modelid";
                using (SqlCommand updateCmd = new SqlCommand(updateQtyQuery, conn))
                {
                    updateCmd.Parameters.AddWithValue("@qty", quantity);
                    updateCmd.Parameters.AddWithValue("@modelid", modelId);
                    updateCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cập nhật kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitUpdateStock();
            }
        }
        #endregion

        #region Report By Day
        private void dtpSelectDay_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpSelectDay.Value.Date;

            if (selectedDate > DateTime.Now.Date)
            {
                MessageBox.Show("Không được chọ ngày trong tương lai!", "Cảnh báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpSelectDay.Value = DateTime.Now;
                return;
            }
        }
        private void lblSearchByDay_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpSelectDay.Value.Date;

            DataTable dt = new DataTable();
            decimal total = 0m;

            string sql = @"
                SELECT 
                    s.SlsId,
                    c.CName,
                    m.ModelNum,
                    s.IMEINO,
                    s.Price
                FROM tbl_Sales s
                INNER JOIN tbl_Mobile mo ON s.IMEINO = mo.IMEINO
                INNER JOIN tbl_Model m  ON mo.ModelId = m.ModelId
                INNER JOIN tbl_Company c ON m.ComId = c.ComId
                WHERE s.PurchageDate = @Date
                ORDER BY s.SlsId;";

            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = selectedDate;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            dtgvReportByDay.DataSource = dt;
            foreach (DataRow row in dt.Rows)
            {
                if (row["Price"] != DBNull.Value)
                    total += Convert.ToDecimal(row["Price"]);
            }
            lblTotalByDay.Text = $"Total for {selectedDate:dd-MM-yyyy}: {total}";
        }

        #endregion
        #region Report Date to Date
        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpStart.Value.Date;

            if (startDate > DateTime.Now.Date)
            {
                MessageBox.Show("Không được chọ ngày trong tương lai!", "Cảnh báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpStart.Value = DateTime.Now;
                return;
            }
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            DateTime endDate = dtpEnd.Value.Date;

            if (endDate > DateTime.Now.Date)
            {
                MessageBox.Show("Không được chọ ngày trong tương lai!", "Cảnh báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEnd.Value = DateTime.Now;
                return;
            }
        }
        private void lblSearchDtoD_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStart.Value.Date;
            DateTime endDate = dtpEnd.Value.Date;

            DataTable dt = new DataTable();
            decimal total = 0m;

            string sql = @"
                SELECT 
                    s.SlsId,
                    c.CName,
                    m.ModelNum,
                    s.IMEINO,
                    s.Price
                FROM tbl_Sales s
                INNER JOIN tbl_Mobile mo ON s.IMEINO = mo.IMEINO
                INNER JOIN tbl_Model m  ON mo.ModelId = m.ModelId
                INNER JOIN tbl_Company c ON m.ComId = c.ComId
                WHERE s.PurchageDate >= @StartDate AND s.PurchageDate <= @EndDate
                ORDER BY s.SlsId;";

            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@StartDate", SqlDbType.Date).Value = startDate;
                cmd.Parameters.Add("@EndDate", SqlDbType.Date).Value = endDate;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            dtgvReportDtoD.DataSource = dt;
            foreach (DataRow row in dt.Rows)
            {
                if (row["Price"] != DBNull.Value)
                    total += Convert.ToDecimal(row["Price"]);
            }
            lblTotalDtoD.Text = $"Total from {startDate:dd-MM-yyyy} to {endDate:dd-MM-yyyy}: {total}";
        }
        #endregion
        #region Export to Excel
        private void btnExcel1_Click(object sender, EventArgs e)
        {
            if (dtgvReportByDay.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new ClosedXML.Excel.XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Report");

                            // Write header
                            for (int col = 0; col < dtgvReportByDay.Columns.Count; col++)
                            {
                                var headerCell = worksheet.Cell(1, col + 1);
                                headerCell.Value = dtgvReportByDay.Columns[col].HeaderText;
                                headerCell.Style.Font.Bold = true;
                                headerCell.Style.Font.FontSize = 14;
                                headerCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                headerCell.Style.Fill.BackgroundColor = XLColor.LightGray;
                            }

                            // Write data
                            int currentRow = 2;
                            foreach (DataGridViewRow row in dtgvReportByDay.Rows)
                            {
                                if (row.IsNewRow) continue; // Bỏ qua dòng trống cuối

                                for (int col = 0; col < dtgvReportByDay.Columns.Count; col++)
                                {
                                    var dataCell = worksheet.Cell(currentRow, col + 1);
                                    dataCell.Value = row.Cells[col].Value?.ToString();

                                    // Set font size to 14 for each data cell
                                    dataCell.Style.Font.FontSize = 14;
                                }
                                currentRow++;
                            }

                            // Auto adjust column width
                            worksheet.Columns().AdjustToContents();

                            workbook.SaveAs(sfd.FileName);
                        }

                        MessageBox.Show("Xuất file Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExcel2_Click(object sender, EventArgs e)
        {
            if (dtpStart.Value.Date > dtpEnd.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 1. Query dữ liệu từ bảng tbl_Sales theo khoảng ngày
                        string sql = "SELECT * FROM tbl_Sales WHERE PurchageDate BETWEEN @fromDate AND @toDate";

                        using (SqlConnection conn = GetConnection())
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@fromDate", dtpStart.Value.Date);
                            cmd.Parameters.AddWithValue("@toDate", dtpEnd.Value.Date);

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Không có dữ liệu để xuất Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // 2. Xuất dữ liệu ra Excel
                            using (var workbook = new ClosedXML.Excel.XLWorkbook())
                            {
                                var worksheet = workbook.Worksheets.Add("Report");

                                // Ghi Header
                                for (int col = 0; col < dtgvReportByDay.Columns.Count; col++)
                                {
                                    var headerCell = worksheet.Cell(1, col + 1);
                                    headerCell.Value = dtgvReportByDay.Columns[col].HeaderText;
                                    headerCell.Style.Font.Bold = true;
                                    headerCell.Style.Font.FontSize = 14;
                                    headerCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                    headerCell.Style.Fill.BackgroundColor = XLColor.LightGray;
                                }

                                // Ghi dữ liệu
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dt.Columns.Count; j++)
                                    {
                                        var dataCell = worksheet.Cell(i + 2, j + 1);
                                        dataCell.Value = dt.Rows[i][j]?.ToString();
                                        dataCell.Style.Font.FontSize = 14;
                                    }
                                }

                                workbook.SaveAs(sfd.FileName);

                                // Auto adjust column width
                                worksheet.Columns().AdjustToContents();

                                workbook.SaveAs(sfd.FileName);
                            }

                            MessageBox.Show("Xuất file Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion
    }
}
