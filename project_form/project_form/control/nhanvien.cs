using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_form.control
{
    class nhanvien : DbCon
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public nhanvien()
        {
            loadnhanvien();
        }

        public void loadnhanvien()
        {
            string sql = "select * from tbl_NhanVien";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "nhanvien");

            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["nhanvien"].Columns[0];
            ds.Tables["nhanvien"].PrimaryKey = key;
        }

        public DataTable tablenhanvien()
        {
            return ds.Tables["nhanvien"];
        }
    }
}
