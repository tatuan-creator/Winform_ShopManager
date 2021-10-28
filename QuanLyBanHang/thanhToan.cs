using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanHang
{
    public partial class thanhToan : Form
    {
        SQLBANHANGEntities3 qlbh = new SQLBANHANGEntities3();
        public static string TienThanhToan ;
        public static string SoHoaDon;
        public static string MaKhachHang;
        public static string MaSP;
        public static string SoLuong;
        public static string DonGia;
        public static string DisCount;
        public thanhToan()
        {
            InitializeComponent();
        }
        

        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-FB3OD3C\SQLEXPRESS;Initial Catalog=SQLBANHANG;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tb = new DataTable();
        /*void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select CTHD.THANHTIEN from CTHD where SOHD = ";
            adapter.SelectCommand = cmd;
            tb.Clear();
            adapter.Fill(tb);
            
        }*/

        void getData(string data)
        {
            tbThanhToan.Text = "";
            tbThanhToan.Text = data;
        }
        void load (string data)
        {
            tbThanhToan.Text = "";
            tbThanhToan.Text = data;
        }
        private void thanhToan_Load(object sender, EventArgs e)
        {
            
            FormMain formMain = new FormMain();
            FormMain f = formMain;
            f.truyenTien = new FormMain.truyenThanhToan(load);
            /////////////
            tbThanhToan.Text = TienThanhToan;
            lbSoHoaDon.Text = "So Hoa Don : " + SoHoaDon;


            //////////////
            //tbTIenNhap.Text = toTien.ToString();
        }
        static int toTien = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            toTien = 50000;
            tbTIenNhap.Text = toTien.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            toTien = 100000;
            tbTIenNhap.Text = toTien.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            toTien = 200000;
            tbTIenNhap.Text = toTien.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            toTien = 500000;
            tbTIenNhap.Text = toTien.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ///
        private void button2_Click(object sender, EventArgs e)
        {
            //kiemtra();
            // loadData();
            DateTime dt = DateTime.Now;
                int SHD = Convert.ToInt32(thanhToan.SoHoaDon);
                string msp = thanhToan.MaSP;
                int SL = Convert.ToInt32(thanhToan.SoLuong);
                int DG = Convert.ToInt32(thanhToan.DonGia);
                int TT = Convert.ToInt32(thanhToan.TienThanhToan);
                int G = Convert.ToInt32(thanhToan.DisCount);
                int tt = Convert.ToInt32(tbTienThoi.Text);
                int t = Convert.ToInt32(tbTienThoi.Text);
                int n = t * (-1);
                qlbh.HOADONs.Add(new HOADON() { SOHD = SHD , MAKH = thanhToan.MaKhachHang ,NGHD = dt});
                qlbh.SaveChanges();
            
            if(tt >=0 )
            {
                CTHD chiTietHoaDon = new CTHD()
                {
                    SOHD = SHD,
                    MASP = msp,
                    SL = SL,
                    DONGIA = DG,
                    THANHTIEN = TT,
                    GIAM = G,
                    


                };
                qlbh.CTHDs.Add(chiTietHoaDon);
                qlbh.SaveChanges();
            }
            else
            {
                CTHD chiTietHoaDon = new CTHD()
                {
                    SOHD = SHD,
                    MASP = msp,
                    SL = SL,
                    DONGIA = DG,
                    THANHTIEN = TT,
                    GIAM = G,
                    NO = n,


                };
                qlbh.CTHDs.Add(chiTietHoaDon);
                qlbh.SaveChanges();
            }
                
               


                
            DialogResult dia = MessageBox.Show("Thanh Toan Thanh Cong", DialogResult.OK.ToString());
            if(dia == DialogResult.OK)
            {
                this.Close();
            }

            
        }

        /*private bool kiemtra()
        {
            if()
            return false;
        }*/

        /// 
        private void tbTIenNhap_TextChanged(object sender, EventArgs e)
        {
            if (tbTIenNhap.Text == "") 
            {

            }
            
            else 
            {
                int tt = Convert.ToInt32(tbThanhToan.Text);
                int tn = Convert.ToInt32(tbTIenNhap.Text);
                int t = tn - tt;
                tbTienThoi.Text = t.ToString();
            }
            
        }

        private void tbTienThoi_TextChanged(object sender, EventArgs e)
        {
            int tt = Convert.ToInt32(tbTienThoi.Text);
            if(tt < 0)
            {
                label3.Text = "Tien No ";
                btTraDu.BackColor = Color.Linen;
                btNo.BackColor = Color.Red;
            }
            else
            {
                label3.Text = "Tiền Thối Lại ";
                btNo.BackColor = Color.Linen;
                btTraDu.BackColor = Color.Red;
            }
        }

        private void tbThanhToan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
