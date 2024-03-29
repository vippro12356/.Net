﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_form.control;
using project_form.model;
namespace project_form
{
    public partial class Nhanvien : Form
    {
        services sv = new services();
        NhanVien nv_control = new NhanVien();
        public Nhanvien()
        {
            InitializeComponent();
            loadlistview();
        }

        public void loadlistview()
        {
            lsvDSNhanVien.Items.Clear();
            DataTable dt = nv_control.TableNhanVien();
            foreach (DataRow row in dt.Rows)
            {
                string manv = row.ItemArray[0].ToString();
                string tennv = row.ItemArray[1].ToString();
                string ngaysinh = row.ItemArray[2].ToString();
                string gioitinh = row.ItemArray[3].ToString();
                string diachi = row.ItemArray[4].ToString();
                string dienthoai = row.ItemArray[5].ToString();
                string email = row.ItemArray[6].ToString();

                ListViewItem item = new ListViewItem(new[] { manv, tennv, ngaysinh, gioitinh, diachi, dienthoai, email });
                lsvDSNhanVien.Items.Add(item);
            }
        }

        private void btnThem_MouseEnter(object sender, EventArgs e)
        {
            sv.mouseenter(btnThem);
        }

        private void btnThem_MouseLeave(object sender, EventArgs e)
        {
            sv.mouseleave(btnThem);
        }

        private void btnXoa_MouseEnter(object sender, EventArgs e)
        {
            sv.mouseenter(btnXoa);
        }

        private void btnXoa_MouseLeave(object sender, EventArgs e)
        {
            sv.mouseleave(btnXoa);
        }

        private void btnSua_MouseEnter(object sender, EventArgs e)
        {
            sv.mouseenter(btnSua);
        }

        private void btnSua_MouseLeave(object sender, EventArgs e)
        {
            sv.mouseleave(btnSua);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(t => t.Text.Length == 0))
            {
                MessageBox.Show("Nhập dữ liệu đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                NhanVienModel nv = new NhanVienModel(txtTenNV.Text, dtpNgaySinh.Value, cmbGioiTinh.Text, txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text);
                if (nv_control.ThemNhanVien(nv))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadlistview();
                }
                else
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void lsvDSNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDSNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvDSNhanVien.SelectedItems[0];
                txtTenNV.Text = item.SubItems[1].Text;
                dtpNgaySinh.Text = item.SubItems[2].Text;
                cmbGioiTinh.Text = item.SubItems[3].Text;
                txtDiaChi.Text = item.SubItems[4].Text;
                txtDienThoai.Text = item.SubItems[5].Text;
                txtEmail.Text = item.SubItems[6].Text;
            }
        }
    }
}
