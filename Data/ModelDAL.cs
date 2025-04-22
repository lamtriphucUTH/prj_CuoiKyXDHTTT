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
    }
}
