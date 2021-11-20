using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_form.model;

namespace project_form.control
{
    class NhanVien : DbCon
    {
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommandBuilder build;
        DataSet ds = new DataSet();
        public NhanVien()
        {
            LoadDLNhanVien();
        }

        public void LoadDLNhanVien()
        {
            string sql = "select * from tbl_NhanVien";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "nhanvien");

            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["nhanvien"].Columns[0];
            ds.Tables["nhanvien"].PrimaryKey = key;
        }

        public DataTable TableNhanVien()
        {
            return ds.Tables["nhanvien"];
        }

        public bool ThemNhanVien(NhanVienModel nv)
        {
            try
            {
                DataRow row = ds.Tables["nhanvien"].NewRow();
                row["MaNV"] = nv.MaNV;
                row["TenNV"] = nv.TenNV;
                row["NgaySinh"] = nv.NgaySinh;
                row["GioiTinh"] = nv.GioiTinh;
                row["DiaChi"] = nv.DiaChi;
                row["DienThoai"] = nv.DienThoai;
                row["Email"] = nv.Email;

                ds.Tables["nhanvien"].Rows.Add(row);

                string cmd = "select * from tbl_NhanVien";
                da = new SqlDataAdapter(cmd, conn);
                build = new SqlCommandBuilder(da);

                da.Update(ds, "nhanvien");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaNhanVien(NhanVienModel nv)
        {
            try
            {
                DataRow row = ds.Tables["nhanvien"].Rows.Find(nv.MaNV);
                row["TenNV"] = nv.TenNV;
                row["NgaySinh"] = nv.NgaySinh;
                row["GioiTinh"] = nv.GioiTinh;
                row["DiaChi"] = nv.DiaChi;
                row["DienThoai"] = nv.DienThoai;
                row["Email"] = nv.Email;

                string cmd = "select * from tbl_NhanVien";
                da = new SqlDataAdapter(cmd, conn);
                build = new SqlCommandBuilder(da);

                da.Update(ds, "nhanvien");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool XoaNhanVien(string maNV)
        {
            try
            {
                DataRow row = ds.Tables["nhanvien"].Rows.Find(maNV);
                row.Delete();

                string cmd = "select * from tbl_NhanVien";
                SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
                SqlCommandBuilder build = new SqlCommandBuilder(da);

                da.Update(ds, "nhanvien");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
