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
    public class DBSach
    {
        DAL db = new DAL();
        public DataSet GetAllSach(ref string err)
        {
            try
            {
                return db.ExecuteQueryDataSet("SP_GetAllSach", CommandType.StoredProcedure, null);

            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }

        }
        public DataSet TimKiemTHeoTenSach(string tenSach, ref string err)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@TenSach", SqlDbType.NVarChar) { Value = tenSach }
            };
            try
            {

                return db.ExecuteQueryDataSet("SP_TimKiemSachTheoTenSach", CommandType.StoredProcedure, parameters);

            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }

        public DataSet TimKiemTheoMaSach(int maSach, ref string err)
        {
            SqlParameter[] parameters = new SqlParameter[]
           {
               new SqlParameter("@MaSach", SqlDbType.Int) { Value = maSach }
           };
            try
            {
                return db.ExecuteQueryDataSet("SP_TimKiemSachTheoMaSach", CommandType.StoredProcedure, parameters);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }

        }
        

        public DataSet GetAllNamXuatBan(ref string err) {
            try
            {
                return db.ExecuteQueryDataSet("SP_GetAllNamXuatBan", CommandType.StoredProcedure, null);
            }
            catch (Exception ex)
            {
                err = ex.Message; return null;
            }
        }

        public DataSet GetAllTacGia(ref string err)
        {
            try
            {
                return db.ExecuteQueryDataSet("SP_GetAllTacGia", CommandType.StoredProcedure, null);
            }
            catch (Exception ex)
            {
                err = ex.Message; return null;
            }
        }

        public DataSet GetAllTheLoai(ref string err)
        {
            try
            {
                return db.ExecuteQueryDataSet("SP_GetAllTheLoai", CommandType.StoredProcedure, null);
            }
            catch (Exception ex)
            {
                err = ex.Message; return null;
            }
        }   
        public DataSet TimKiemTheoTacGia(string tenTacGia, ref string err)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenTacGia", SqlDbType.NVarChar) { Value = tenTacGia }
            };
            try
            {
                return db.ExecuteQueryDataSet("SP_TimKiemSachTheoTacGia", CommandType.StoredProcedure, parameters);
            }
            catch (Exception ex)
            {
                err = ex.Message; return null;
            }
        }
        public DataSet TimKiemTheoNamXuatBan(int namXuatBan, ref string err)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@NamXuatBan", SqlDbType.Int) { Value = namXuatBan }
            };
            try
            {
                return db.ExecuteQueryDataSet("SP_TimKiemSachTheoNamXuatBan", CommandType.StoredProcedure, parameters);
            }
            catch (Exception ex)
            {
                err = ex.Message; return null;
            }
        }

        public DataSet TimKiemTheoTheLoai(string tenTheLoai, ref string err)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenTheLoai", SqlDbType.NVarChar) { Value = tenTheLoai }
            };
            try
            {
                return db.ExecuteQueryDataSet("SP_TimKiemSachTheoTheLoai2", CommandType.StoredProcedure, parameters);
            }
            catch (Exception ex)
            {
                err = ex.Message; return null;
            }
        }

    }
}

