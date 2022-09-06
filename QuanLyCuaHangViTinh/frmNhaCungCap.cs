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
    public partial class frmNhaCungCap : Form
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
        public frmNhaCungCap()
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

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNCC();
        }
        private void HienThiDanhSachNCC()
        {
            OpenConnection();

            OleDbCommand sqlCmd = new OleDbCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM NhaCungCap";
            sqlCmd.Connection = connect;

            OleDbDataReader reader = sqlCmd.ExecuteReader();
            listNCC.Items.Clear();
            while (reader.Read())
            {
                string maNCC = reader.GetString(0);
                string maSP = reader.GetString(1);
                string maCH = reader.GetString(2);
                string soLuong = reader.GetInt32(3).ToString();
                string thoiGianGiao = reader.GetDateTime(4).ToString();
                string tenNCC = reader.GetString(5);

                ListViewItem lvi = new ListViewItem(maNCC);
                lvi.SubItems.Add(tenNCC);
                lvi.SubItems.Add(maSP);
                lvi.SubItems.Add(maCH);
                lvi.SubItems.Add(soLuong);
                lvi.SubItems.Add(thoiGianGiao);

                listNCC.Items.Add(lvi);
            }
            reader.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            OpenConnection();

            OleDbCommand sqlCmd = new OleDbCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "insert into [NhaCungCap](MaNhaCungCap, MaSanPham, MaCuaHang, SoLuong, ThoiGianGiao, TenNhaCungCap) values (@MaNhaCungCap, @MaSanPham, @MaCuaHang, @SoLuong, @ThoiGianGiao, @TenNhaCungCap)";

            OleDbParameter parMaNCC = new OleDbParameter("@MaNhaCungCap", OleDbType.BSTR);
            parMaNCC.Value = txtMaNCC.Text.Trim();
            sqlCmd.Parameters.Add(parMaNCC);

            OleDbParameter parMaSP = new OleDbParameter("@MaSanPham", OleDbType.BSTR);
            parMaSP.Value = txtMaSP.Text.Trim();
            sqlCmd.Parameters.Add(parMaSP);

            OleDbParameter parMaCH = new OleDbParameter("@MaCuaHang", OleDbType.BSTR);
            parMaCH.Value = txtMaCH.Text.Trim();
            sqlCmd.Parameters.Add(parMaCH);

            OleDbParameter parSL = new OleDbParameter("@SoLuong", OleDbType.BSTR);
            parSL.Value = txtSL.Text.Trim();
            sqlCmd.Parameters.Add(parSL);

            OleDbParameter parTGG = new OleDbParameter("@ThoiGianGiao", OleDbType.BSTR);
            parTGG.Value = txtTGGiao.Text.Trim();
            sqlCmd.Parameters.Add(parTGG);

            OleDbParameter parTen = new OleDbParameter("@TenNhaCungCap", OleDbType.BSTR);
            parTen.Value = txtTenNCC.Text.Trim();
            sqlCmd.Parameters.Add(parTen);

            sqlCmd.Connection = connect;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Thanh cong!", "Thong Bao");
                txtMaNCC.Clear();
                txtMaSP.Clear();
                txtMaCH.Clear();
                txtSL.Clear();
                txtTGGiao.Clear();
                txtTenNCC.Clear();
                HienThiDanhSachNCC();
            }
            else
            {
                MessageBox.Show("That bai!", "Thong Bao");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
