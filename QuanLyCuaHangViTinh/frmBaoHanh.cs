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
    public partial class frmBaoHanh : Form
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
        public frmBaoHanh()
        {
            InitializeComponent();
        }

        private void frmBaoHanh_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();   
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.ShowDialog();
            this.Close();
        }
        
        public void HienThiDanhSach() {
            OpenConnection();

            OleDbCommand sqlCmd = new OleDbCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM BaoHanh";
            sqlCmd.Connection = connect;

            OleDbDataReader reader = sqlCmd.ExecuteReader();
            listBH.Items.Clear();
            while (reader.Read())
            {
                string maBH = reader.GetString(0);
                string maHD = reader.GetString(1);
                string ngayGiao = reader.GetDateTime(2).ToString();
                string baoHanh = reader.GetBoolean(3).ToString();

                ListViewItem lvi = new ListViewItem(maBH);
                lvi.SubItems.Add(maHD);
                lvi.SubItems.Add(ngayGiao);
                lvi.SubItems.Add(baoHanh);

                listBH.Items.Add(lvi);
            }
            reader.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            OpenConnection();

            OleDbCommand sqlCmd = new OleDbCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "insert into [BaoHanh](MaBH, MaHD, NgayGiaoHangThucTe, BaoHanh) values (@MaBH, @MaHD, @NgayGiaoHangThucTe, @BaoHanh)";

            OleDbParameter parMaBH = new OleDbParameter("@MaBH", OleDbType.BSTR);
            parMaBH.Value = txtMaBH.Text.Trim();
            sqlCmd.Parameters.Add(parMaBH);

            OleDbParameter parMaHD = new OleDbParameter("@MaHD", OleDbType.BSTR);
            parMaHD.Value = txtMaHD.Text.Trim();
            sqlCmd.Parameters.Add(parMaHD);

            OleDbParameter parNgayGiaoHangThucTe = new OleDbParameter("@NgayGiaoHangThucTe", OleDbType.BSTR);
            parNgayGiaoHangThucTe.Value = txtNgayGiaoHang.Text.Trim();
            sqlCmd.Parameters.Add(parNgayGiaoHangThucTe);

            OleDbParameter parBaoHanh = new OleDbParameter("@BaoHanh", OleDbType.BSTR);
            parBaoHanh.Value = 0;
            sqlCmd.Parameters.Add(parBaoHanh);

            sqlCmd.Connection = connect;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Thanh cong!", "Thong Bao");
                txtNgayGiaoHang.Clear();
                txtMaHD.Clear();
                txtMaBH.Clear();
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("That bai!", "Thong Bao");
            }
        }
    }
}
