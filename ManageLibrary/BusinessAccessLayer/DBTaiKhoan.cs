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
        public bool Login(string Email, string Password, ref string err)
        {
            // Defining parameters for the stored procedure
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", SqlDbType.NVarChar) { Value = Email },
                new SqlParameter("@MatKhau", SqlDbType.NVarChar) { Value = Password }
            };

            try
            {
                // Execute the stored procedure and get the count (int)
                var result = db.ExecuteScalar("SP_Login", CommandType.StoredProcedure, parameters);

                // If result is not null and greater than 0, login is successful
                if (result != null && Convert.ToInt32(result) > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                // In case of exception, set the error message
                err = ex.Message;
                return false;
            }
        }
    }
}
