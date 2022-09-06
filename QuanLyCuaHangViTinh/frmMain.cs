using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangViTinh
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKhachHang = new frmKhachHang();
            this.Hide();
            frmKhachHang.ShowDialog();
            this.Close();
        }

        private void btSP_Click(object sender, EventArgs e)
        {
            frmSanPham frmSanPham = new frmSanPham();
            this.Hide();
            frmSanPham.ShowDialog();
            this.Close();
        }

        private void btNCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frmNhaCungCap = new frmNhaCungCap();
            this.Hide();
            frmNhaCungCap.ShowDialog();
            this.Close();
        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNhanVien = new frmNhanVien();
            this.Hide();
            frmNhanVien.ShowDialog();
            this.Close();
        }

        private void btBaoHanh_Click(object sender, EventArgs e)
        {
            frmBaoHanh frmBaoHanh = new frmBaoHanh();
            this.Hide();
            frmBaoHanh.ShowDialog();
            this.Close();
        }
    }
}
