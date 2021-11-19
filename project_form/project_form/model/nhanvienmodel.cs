using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_form.model
{
    public class nhanvienmodel
    {
        public int manv { get; set; }
        public string tennv { get; set; }
        public DateTime ngaysinh { get; set; }
        public string gioitinh { get; set; }
        public string diachi { get; set; }
        public string dienthoai { get; set; }
        public string email { get; set; }

        public nhanvienmodel(int manv, string tennv, DateTime ngaysinh, string gioitinh, string diachi, string dienthoai, string email)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.email = email;
        }
    }
}
