using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj_CuoiKyXDHTTT.DTO;

namespace prj_CuoiKyXDHTTT.Data
{
    class ModelDAL
    {
        public bool AddModel(ModelDTO model)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_AddModel", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ModelId", model.ModelId);
                cmd.Parameters.AddWithValue("@ComId", model.Company.ComId);
                cmd.Parameters.AddWithValue("@ModelNum", model.ModelNum);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public List<String> GetModelNumbers()
        {
            List<String> modelNumbers = new List<String>();
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "SELECT ModelNum FROM tbl_Model";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    modelNumbers.Add(reader["ModelNum"].ToString());
                }
            }
            return modelNumbers;
        }
        public int? GetModelIdByNumber(string modelNum)
        {
            int? modelId = null;

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "SELECT ModelId FROM tbl_Model WHERE ModelNum = @ModelNum";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ModelNum", modelNum);

                conn.Open();

                object result = cmd.ExecuteScalar();
                if (result != null)
                    modelId = Convert.ToInt32(result);
                
            }
            return modelId;
        }
    }
}
