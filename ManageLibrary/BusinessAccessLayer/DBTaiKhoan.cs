using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class DBTaiKhoan
    {
        DAL db = new DAL();
        public object Login(string email, string password, ref string err)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", SqlDbType.NVarChar) { Value = email },
                new SqlParameter("@MatKhau", SqlDbType.NVarChar) { Value = password }
            };
            try
            {
                return db.ExecuteQueryDataSet("SP_Login", CommandType.StoredProcedure, parameters);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }

        public int GetMaTaiKhoanByEmail(string email, ref string err)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Email", SqlDbType.NVarChar) { Value = email }
            };

            try
            {
                // Execute the function and get the scalar result
                object result = db.ExecuteScalar("SELECT dbo.fn_GetMaTaiKhoanByEmail(@Email)", CommandType.Text, parameters);

                // If the result is not null, return the value, otherwise return 0 or handle as necessary
                if (result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return 0;  // Or handle if no account is found
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return 0;  // Or another appropriate value
            }
        }



    }
}
