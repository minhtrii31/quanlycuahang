using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QuanLyCuaHangViTinh
{
    public partial class frmSanPham : Form
    {
        string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\PTTKHT.accdb";

        OleDbConnection connect = null;

        // Open connection

        public void OpenConnection()
        {
            if (connect == null)
            {
                connect = new OleDbConnection(strCon);
            }
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        // Close connection

        public void CloseConnection()
        {
            if (connect.State == ConnectionState.Open && connect != null)
            {
                connect.Close();
            }
        }
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.ShowDialog();
            this.Close();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();
        }
        private void HienThiDanhSachSanPham()
        {
            OpenConnection();

            OleDbCommand sqlCmd = new OleDbCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM SanPham";
            sqlCmd.Connection = connect;

            OleDbDataReader reader = sqlCmd.ExecuteReader();
            listSP.Items.Clear();
            while (reader.Read())
            {
                string maSP = reader.GetString(0);
                string tenSP = reader.GetString(1);
                string maNCC = reader.GetString(2);
                string maLoaiSP = reader.GetString(3);
                string donGia = reader.GetDecimal(4).ToString();
                string tonKho = reader.GetInt32(5).ToString();

                ListViewItem lvi = new ListViewItem(maSP);
                lvi.SubItems.Add(tenSP);
                lvi.SubItems.Add(maNCC);
                lvi.SubItems.Add(maLoaiSP);
                lvi.SubItems.Add(donGia);
                lvi.SubItems.Add(tonKho);

                listSP.Items.Add(lvi);
            }
            reader.Close();
        }

        private void btClose_Click_1(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.ShowDialog();
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            OpenConnection();

            OleDbCommand sqlCmd = new OleDbCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "insert into [SanPham](MaSP, TenSP, MaNhaCungCap, MaLoaiSP, DonGia, LuongTonKho) values (@maSP, @tenSP, @maNCC, @maLoai, @donGia, @tonKho)";

            OleDbParameter parMa = new OleDbParameter("@maSP", OleDbType.BSTR);
            parMa.Value = txtMaSP.Text.Trim();
            sqlCmd.Parameters.Add(parMa);

            OleDbParameter parTen = new OleDbParameter("@tenSP", OleDbType.BSTR);
            parTen.Value = txtTenSP.Text.Trim();
            sqlCmd.Parameters.Add(parTen);

            OleDbParameter parMaNCC = new OleDbParameter("@maNCC", OleDbType.BSTR);
            parMaNCC.Value = txtMaNCC.Text.Trim();
            sqlCmd.Parameters.Add(parMaNCC);

            OleDbParameter parLoai = new OleDbParameter("@maLoai", OleDbType.BSTR);
            parLoai.Value = txtMaLoaiSP.Text.Trim();
            sqlCmd.Parameters.Add(parLoai);

            OleDbParameter parGia = new OleDbParameter("@donGia", OleDbType.BSTR);
            parGia.Value = txtDonGia.Text.Trim();
            sqlCmd.Parameters.Add(parGia);

            OleDbParameter parSL = new OleDbParameter("@tonKho", OleDbType.BSTR);
            parSL.Value = txtSoLuong.Text.Trim();
            sqlCmd.Parameters.Add(parSL);

            sqlCmd.Connection = connect;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Thanh cong!", "Thong Bao");
                txtMaSP.Clear();
                txtTenSP.Clear();
                txtMaNCC.Clear();
                txtMaLoaiSP.Clear();
                txtDonGia.Clear();
                txtSoLuong.Clear();
                HienThiDanhSachSanPham();
            }
            else
            {
                MessageBox.Show("That bai!", "Thong Bao");
            }
        }
    }
}
