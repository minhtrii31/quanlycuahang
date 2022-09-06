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
    public partial class frmKhachHang : Form
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

        public frmKhachHang()
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

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            OpenConnection();

            OleDbCommand sqlCmd = new OleDbCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM KhachHang";
            sqlCmd.Connection = connect;

            OleDbDataReader reader = sqlCmd.ExecuteReader();
            listKH.Items.Clear();
            while (reader.Read())
            {
                string maKH = reader.GetInt32(0).ToString();
                string hoKH = reader.GetString(1);
                string tenKH = reader.GetString(2);
                string diachiKH = reader.GetString(3);
                string sodienthoaiKH = reader.GetString(4);
                string diem = reader.GetString(5);
                string hanmuc = reader.GetString(6);
                string lanmua = reader.GetString(7);
                string ghichu;
                if (reader.IsDBNull(8))
                {
                    ghichu = "";
                }
                else
                {
                    ghichu = reader.GetString(8);
                }

                ListViewItem lvi = new ListViewItem(maKH);
                lvi.SubItems.Add(hoKH + " " + tenKH);
                lvi.SubItems.Add(diachiKH);
                lvi.SubItems.Add(sodienthoaiKH);
                lvi.SubItems.Add(diem);
                lvi.SubItems.Add(hanmuc);
                lvi.SubItems.Add(lanmua);
                lvi.SubItems.Add(ghichu);

                listKH.Items.Add(lvi);
            }
            reader.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            OpenConnection();

            int indexTrangCuoi = 0;

            OleDbCommand sqlCmd = new OleDbCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "insert into [KhachHang](HoKH, TenKH, DiaChi, SdtKH, SoDiem, HangMucThe, SoLanKM, GhiChu) values (@hoKH, @tenKH, @diachiKH, @sdtKH, @sodiem, @hangmucthe, @solanKM, @ghichu)";

            OleDbParameter parHo = new OleDbParameter("@hoKH", OleDbType.BSTR);
            for (int i = txtTenKhachHang.Text.Length; i > 0; i--)
            {
                if (txtTenKhachHang.Text.Substring(i - 1, 1) == " ")
                {
                    indexTrangCuoi = i - 1;
                    break;
                }
            }
            parHo.Value = txtTenKhachHang.Text.Substring(0, indexTrangCuoi);
            sqlCmd.Parameters.Add(parHo);

            OleDbParameter parTen = new OleDbParameter("@tenKH", OleDbType.BSTR);
            parTen.Value = txtTenKhachHang.Text.Substring(indexTrangCuoi + 1);
            sqlCmd.Parameters.Add(parTen);

            OleDbParameter parDiaChi = new OleDbParameter("@diachiKH", OleDbType.BSTR);
            parDiaChi.Value = txtDiaChiKhachHang.Text.Trim();
            sqlCmd.Parameters.Add(parDiaChi);

            OleDbParameter parSdt = new OleDbParameter("@sdtKH", OleDbType.BSTR);
            parSdt.Value = txtSoDienThoai.Text.Trim();
            sqlCmd.Parameters.Add(parSdt);

            OleDbParameter parDiem = new OleDbParameter("@sodiem", OleDbType.BSTR);
            parDiem.Value = txtDiem.Text.Trim();
            sqlCmd.Parameters.Add(parDiem);

            OleDbParameter parThe = new OleDbParameter("@hangmucthe", OleDbType.BSTR);
            parThe.Value = "0";
            sqlCmd.Parameters.Add(parThe);

            OleDbParameter parLanKM = new OleDbParameter("@solanKM", OleDbType.BSTR);
            parLanKM.Value = "1";
            sqlCmd.Parameters.Add(parLanKM);

            OleDbParameter parGhichu = new OleDbParameter("@ghichu", OleDbType.BSTR);
            parGhichu.Value = "";
            sqlCmd.Parameters.Add(parGhichu);

            sqlCmd.Connection = connect;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Thanh cong!", "Thong Bao");
                txtTenKhachHang.Clear();
                txtDiaChiKhachHang.Clear();
                txtSoDienThoai.Clear();
                txtDiem.Clear();
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("That bai!", "Thong Bao");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            OpenConnection();
            foreach (ListViewItem item in listKH.SelectedItems)
            {
                OleDbCommand sqlCmd = new OleDbCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "DELETE FROM KhachHang WHERE MaKH='" + Int32.Parse(item.SubItems[0].Text) + "'";
                sqlCmd.Connection = connect;

                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thanh cong!", "Thong Bao");
                    HienThiDanhSach();
                }
                else
                {
                    MessageBox.Show("That bai!", "Thong Bao");
                }
            }
        }
    }
}
