using prj_CuoiKyXDHTTT.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_CuoiKyXDHTTT.Data
{
    class MobileDAL
    {
        public bool AddMobile(MobileDTO mobile)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand("sp_AddMobile", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ModelId", mobile.Model.ModelId);
                cmd.Parameters.AddWithValue("@IMEINO", mobile.IMEINO);
                cmd.Parameters.AddWithValue("@Status", mobile.Status);
                cmd.Parameters.AddWithValue("@Warranty", mobile.Warranty);
                cmd.Parameters.AddWithValue("@Price", mobile.Price);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public List<ModelDTO> GetModelsByCompany(int comId)
        {
            var list = new List<ModelDTO>();
            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                "SELECT ModelId, ModelNum FROM tbl_Model WHERE ComId = @ComId", conn))
            {
                cmd.Parameters.AddWithValue("@ComId", comId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ModelDTO
                        {
                            ModelId = (int)reader["ModelId"],
                            ModelNum = reader["ModelNum"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}
