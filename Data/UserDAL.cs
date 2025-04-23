using prj_CuoiKyXDHTTT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_CuoiKyXDHTTT.Data
{
    class UserDAL
    {
        public UserDTO Login(string userName, string pwd)
        {
            UserDTO user = null;

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Login", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@PWD", pwd);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new UserDTO
                            {
                                UserName = reader["UserName"].ToString(),
                                PWD = reader["PWD"].ToString(),
                                EmployeeName = reader["EmployeeName"].ToString(),
                                Address = reader["Address"].ToString(),
                                MobileNumber = reader["MobileNumber"].ToString(),
                                Hint = reader["Hint"].ToString()
                            };
                        }
                    }
                }
            }

            return user;
        }

        public string GetPasswordByHint(string username, string hint)
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    string sql = @"SELECT PWD FROM tbl_user 
                          WHERE UserName = @username AND Hint = @hint";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@hint", hint);

                    conn.Open();
                    return cmd.ExecuteScalar()?.ToString();
                }
            }
            catch (SqlException ex)
            {
                // Ghi log lỗi
                throw new Exception("Lỗi database: " + ex.Message);
            }
        }
    }
}
