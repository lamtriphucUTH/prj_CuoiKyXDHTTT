using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prj_CuoiKyXDHTTT
{
    public partial class ConfirmDetails : Form
    {

        private string connStr = "Data Source=.;Initial Catalog=MobileShoppe;Integrated Security=True";

        private string customerName, mobileNumber, address, email;
        private string company, model, imei;
        private decimal price;

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connStr);
        }

        public ConfirmDetails(string name, string phone, string address, string email,
                             string company, string model, string imei, string price)
        {
            InitializeComponent();

            lblCustomerName.Text = name;
            lblMobileNumber.Text = phone;
            lblAddress.Text = address;
            lblEmail.Text = email;
            lblCompanyName.Text = company;
            lblModelNumber.Text = model;
            lblIMEI.Text = imei;
            lblPrice.Text = price;

            lblWarranty.Text = DateTime.Now.AddMonths(12).ToString("dd/MM/yyyy");
        }

        private void ConfirmDetails_Load(object sender, EventArgs e)
        {
        }

        private string GetNextId(string tableName, string colName)
        {
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                $"SELECT ISNULL(MAX(CAST({colName} AS INT)), 0) + 1 FROM {tableName}", conn))
            {
                conn.Open();
                var obj = cmd.ExecuteScalar();
                return obj.ToString();
            }
        }

        private void txtOK_Click(object sender, EventArgs e)
        {
            string newSaleId = GetNextId("tbl_Sales", "SlsId");
            string newCusId = GetNextId("tbl_Customer", "CusId");

            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand("sp_ProcessSale", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("SaleId", newSaleId);
                cmd.Parameters.AddWithValue("CusId", newCusId);
                cmd.Parameters.AddWithValue("@CustName", lblCustomerName.Text.Trim());
                cmd.Parameters.AddWithValue("@MobileNumber", lblMobileNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", lblEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", lblAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@IMEI", lblIMEI.Text.Trim());
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(lblPrice.Text.Trim()));
                cmd.Parameters.AddWithValue("@PurchaseDate", DateTime.Now);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    //UpdateStockAndStatus(lblModelNumber.Text.Trim(), lblIMEI.Text.Trim());

                    MessageBox.Show("Giao dịch thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Giao dịch thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateStockAndStatus(string modelNum, string imei)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        // Trừ số lượng tồn kho
                        using (SqlCommand cmd1 = new SqlCommand(
                            "UPDATE tbl_Model SET AvailableQty = AvailableQty - 1 WHERE ModelNum = @modelNum", conn, tran))
                        {
                            cmd1.Parameters.AddWithValue("@modelNum", modelNum);
                            cmd1.ExecuteNonQuery();
                        }

                        // Cập nhật status điện thoại
                        using (SqlCommand cmd2 = new SqlCommand(
                            "UPDATE tbl_Mobile SET Status = 'Sold' WHERE IMEINO = @imei", conn, tran))
                        {
                            cmd2.Parameters.AddWithValue("@imei", imei);
                            cmd2.ExecuteNonQuery();
                        }

                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        private void txtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
