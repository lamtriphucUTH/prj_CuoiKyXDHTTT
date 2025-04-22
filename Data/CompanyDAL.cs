using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj_CuoiKyXDHTTT.DTO;

namespace prj_CuoiKyXDHTTT.Data
{
    class CompanyDAL
    {
        public bool AddCompany(CompanyDTO company)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_AddCompany", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ComId", company.ComId.ToString());
                cmd.Parameters.AddWithValue("@CName", company.CName);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public List<string> GetCompanyNames()
        {
            List<string> companyNames = new List<string>();

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "SELECT CName FROM tbl_Company";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    companyNames.Add(reader["CName"].ToString());
                }
            }

            return companyNames;
        }

        public int? GetCompanyIdByName(string cname)
        {
            int? comId = null;

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "SELECT ComId FROM tbl_Company WHERE CName = @CName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CName", cname);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                    comId = Convert.ToInt32(result);
            }

            return comId;
        }
    }
}
