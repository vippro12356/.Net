using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using project_form.model;
namespace project_form.control
{
    public class car:DbCon
    {        
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public car()
        {
            loadxe();
            loaddetail();
        }
        public void loadxe()
        {
            string sql="select * from tbl_MatHang";
            da=new SqlDataAdapter(sql,conn);
            da.Fill(ds,"mathang");
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["mathang"].Columns[0];
            ds.Tables["mathang"].PrimaryKey = key;
        }
        public DataTable tablexe()
        {
            return ds.Tables["mathang"];
        }
        public void loaddetail()
        {
            string sql = "select * from tbl_MatHang,tbl_NhaSanXuat where tbl_MatHang.MaNSX=tbl_NhaSanXuat.MaNSX";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "detail");
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["detail"].Columns[0];
            ds.Tables["detail"].PrimaryKey = key;
        }
        public DataRow findrow(string id)
        {
            DataRow row = ds.Tables["detail"].Rows.Find(id);
            return row;
        }
        public List<carmodel> timkiem(string ten)
        {
            List<carmodel> l = new List<carmodel>();
            foreach(DataRow row in ds.Tables["mathang"].Rows)
            {
                string tenxe=row.ItemArray[1].ToString().Trim();
                if(tenxe.ToLower().Contains(ten.ToLower()))
                {
                    int id=int.Parse(row.ItemArray[0].ToString());
                    string img = row.ItemArray[5].ToString();
                    carmodel c = new carmodel(id, tenxe,img);
                    l.Add(c);
                }
            }
            return l;
        }
    }
}
