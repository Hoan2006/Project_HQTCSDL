using System;
using System.Collections.Generic;
using System.Data;
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

    }
}
