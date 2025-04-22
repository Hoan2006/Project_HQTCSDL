using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL
    {
        string ConnStr = "Data Source=LAPTOP-3EVRR5L8;Initial Catalog=ManageLibrary;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        
        public DAL()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        

        // SELECT (>2 TABLE) - DUNG CAI NAY TIEN HON NHA
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, SqlParameter[] p)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                {
                    cmd.CommandType = ct;
                    if (p != null && p.Length > 0)
                    {
                        cmd.Parameters.AddRange(p);
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
        }

        // SELECT
        public DataTable ExecuteQueryDataTable(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataTable db = new DataTable();
            da.Fill(db);
            return db;
        }
        // Action Query = Insert | Delete | Update | Stored Procedure
        public bool ExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        // COUNT , SUM ,  MAX
        public object ExecuteScalar(string strSQL, CommandType ct, SqlParameter[] p)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                {
                    cmd.CommandType = ct;
                    if (p != null && p.Length > 0)
                    {
                        cmd.Parameters.AddRange(p);
                    }
                    conn.Open();
                    return cmd.ExecuteScalar(); 
                }
            }
        }


    }

}

