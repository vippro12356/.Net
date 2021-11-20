using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_form.model
{
    public class NhanVienModel
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }

        public NhanVienModel(int maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string diaChi, string dienThoai, string email)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.DienThoai = dienThoai;
            this.Email = email;
        }

        public NhanVienModel(string tenNV, DateTime ngaySinh, string gioiTinh, string diaChi, string dienThoai, string email)
        {
            this.TenNV = tenNV;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.DienThoai = dienThoai;
            this.Email = email;
        }
    }
}
