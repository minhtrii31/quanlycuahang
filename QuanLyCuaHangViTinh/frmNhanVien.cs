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
    public partial class frmNhanVien : Form
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
        public frmNhanVien()
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

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        private void HienThiDanhSach()
        {
            OpenConnection();

            OleDbCommand sqlCmd = new OleDbCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM NhanVien";
            sqlCmd.Connection = connect;

            OleDbDataReader reader = sqlCmd.ExecuteReader();
            listNV.Items.Clear();
            while (reader.Read())
            {
                string maNV = reader.GetInt32(0).ToString();
                string tenNV = reader.GetString(1) + " " + reader.GetString(2);
                string maCH = reader.GetString(3);
                string chucVu = reader.GetString(4);
                string sdt = reader.GetString(5);
                string loi = reader.GetString(6);
                string diachi = reader.GetString(7);
                string ngaySinh = reader.GetDateTime(8).ToString();
                string luong = reader.GetDecimal(9).ToString();
                string bonus = reader.GetDecimal(10).ToString();
                string heso = reader.GetDouble(11).ToString();
                string vang = reader.GetString(12);
                string nghi = reader.GetString(13);
                string ca = reader.GetString(14);
                string ghichu;
                if (reader.IsDBNull(15))
                {
                    ghichu = "";
                }
                else
                {
                    ghichu = reader.GetString(15);
                }

                ListViewItem lvi = new ListViewItem(maNV);
                lvi.SubItems.Add(tenNV);
                lvi.SubItems.Add(maCH);
                lvi.SubItems.Add(chucVu);
                lvi.SubItems.Add(sdt);
                lvi.SubItems.Add(loi);
                lvi.SubItems.Add(diachi);
                lvi.SubItems.Add(ngaySinh);
                lvi.SubItems.Add(luong);
                lvi.SubItems.Add(bonus);
                lvi.SubItems.Add(heso);
                lvi.SubItems.Add(vang);
                lvi.SubItems.Add(nghi);
                lvi.SubItems.Add(ca);
                lvi.SubItems.Add(ghichu);

                listNV.Items.Add(lvi);
            }
            reader.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            OpenConnection();

            int indexTrangCuoi = 0;

            OleDbCommand sqlCmd = new OleDbCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "insert into [NhanVien](HoNV, TenNV, MaCH, ChucVu, SoDienThoai, LoiViPham, DiaChi, NgaySinh, LuongNV, ThuongNV, HeSo, SoNgayVang, SoNgayNghi, CaTruc, GhiChu) values (@HoNV, @TenNV, @MaCH, @ChucVu, @SoDienThoai, @LoiViPham, @DiaChi, @NgaySinh, @LuongNV, @ThuongNV, @HeSo, @SoNgayVang, @SoNgayNghi, @CaTruc, @GhiChu)";

            OleDbParameter parHo = new OleDbParameter("@HoNV", OleDbType.BSTR);
            for (int i = txtTen.Text.Length; i > 0; i--)
            {
                if (txtTen.Text.Substring(i - 1, 1) == " ")
                {
                    indexTrangCuoi = i - 1;
                    break;
                }
            }
            parHo.Value = txtTen.Text.Substring(0, indexTrangCuoi);
            sqlCmd.Parameters.Add(parHo);

            OleDbParameter parTen = new OleDbParameter("@TenNV", OleDbType.BSTR);
            parTen.Value = txtTen.Text.Substring(indexTrangCuoi + 1);
            sqlCmd.Parameters.Add(parTen);

            OleDbParameter parMaCH = new OleDbParameter("@MaCH", OleDbType.BSTR);
            parMaCH.Value = txtMaCH.Text.Trim();
            sqlCmd.Parameters.Add(parMaCH);

            OleDbParameter parChucVu = new OleDbParameter("@ChucVu", OleDbType.BSTR);
            parChucVu.Value = txtChucVu.Text.Trim();
            sqlCmd.Parameters.Add(parChucVu);

            OleDbParameter parSDT = new OleDbParameter("@SoDienThoai", OleDbType.BSTR);
            parSDT.Value = txtSDT.Text.Trim();
            sqlCmd.Parameters.Add(parSDT);

            OleDbParameter parLoi = new OleDbParameter("@LoiViPham", OleDbType.BSTR);
            parLoi.Value = "0";
            sqlCmd.Parameters.Add(parLoi);

            OleDbParameter parDiaChi = new OleDbParameter("@DiaChi", OleDbType.BSTR);
            parDiaChi.Value = txtDiaChi.Text.Trim();
            sqlCmd.Parameters.Add(parDiaChi);

            OleDbParameter parNgaySinh = new OleDbParameter("@NgaySinh", OleDbType.BSTR);
            parNgaySinh.Value = txtNgaySinh.Text.Trim();
            sqlCmd.Parameters.Add(parNgaySinh);

            OleDbParameter parLuongNV = new OleDbParameter("@LuongNV", OleDbType.BSTR);
            parLuongNV.Value = "0";
            sqlCmd.Parameters.Add(parLuongNV);

            OleDbParameter parThuongNV = new OleDbParameter("@ThuongNV", OleDbType.BSTR);
            parThuongNV.Value = "0";
            sqlCmd.Parameters.Add(parThuongNV);

            OleDbParameter parHS = new OleDbParameter("@HeSo", OleDbType.BSTR);
            parHS.Value = "1.00";
            sqlCmd.Parameters.Add(parHS);

            OleDbParameter parVang = new OleDbParameter("@SoNgayVang", OleDbType.BSTR);
            parVang.Value = "0";
            sqlCmd.Parameters.Add(parVang);

            OleDbParameter parNghi = new OleDbParameter("@SoNgayNghi", OleDbType.BSTR);
            parNghi.Value = "0";
            sqlCmd.Parameters.Add(parNghi);

            OleDbParameter parTruc = new OleDbParameter("@CaTruc", OleDbType.BSTR);
            parTruc.Value = txtCaTruc.Text.Trim();
            sqlCmd.Parameters.Add(parTruc);

            OleDbParameter parGhiChu = new OleDbParameter("@GhiChu", OleDbType.BSTR);
            parGhiChu.Value = "0";
            sqlCmd.Parameters.Add(parGhiChu);

            sqlCmd.Connection = connect;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Thanh cong!", "Thong Bao");
                txtCaTruc.Clear();
                txtChucVu.Clear();
                txtDiaChi.Clear();
                txtMaCH.Clear();
                txtNgaySinh.Clear();
                txtSDT.Clear();
                txtTen.Clear();
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("That bai!", "Thong Bao");
            }
        }
    }
}
