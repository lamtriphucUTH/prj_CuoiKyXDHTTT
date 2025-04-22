using prj_CuoiKyXDHTTT.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_CuoiKyXDHTTT.Helpers
{
    class IdGenerator
    {
        public static int GenerateNextId(string tableName, string columnName)
        {
            int nextId = 1;  // Giá trị mặc định nếu bảng rỗng

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = $"SELECT MAX(CAST({columnName} AS INT)) FROM {tableName}";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        int maxId = Convert.ToInt32(result);
                        nextId = maxId + 1;
                    }
                }
            }

            return nextId;
        }
    }
}
