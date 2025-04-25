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

namespace prj_CuoiKyXDHTTT
{
    public partial class ConfirmDetails: Form
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
        private void txtOK_Click(object sender, EventArgs e)
        {
            string newSaleId = GetNextId("tbl_Sales", "SlsId");
            string newCusId = GetNextId("tbl_Customer", "CusId");

            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand("sp_ProcessSale", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@SaleId", SqlDbType.NVarChar, 50) { Value = newSaleId });
                cmd.Parameters.Add(new SqlParameter("@CusId", SqlDbType.NVarChar, 50) { Value = newCusId });
                cmd.Parameters.AddWithValue("@CustName", lblCustomerName.Text.Trim());
                cmd.Parameters.AddWithValue("@MobileNumber", lblMobileNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", lblEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", lblAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@IMEI", lblIMEI.Text.Trim());
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(lblPrice.Text.Trim()));
                cmd.Parameters.AddWithValue("@PurchaseDate", DateTime.Parse(lblWarranty.Text));

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Giao dịch thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Giao dịch thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
