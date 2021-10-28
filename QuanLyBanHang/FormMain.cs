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
using System.Configuration;
namespace QuanLyBanHang
{
   
    public partial class FormMain : Form
    {


        static int lick = 0;
        
        public FormMain()
        {
            InitializeComponent();
        }




        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-GISFHHL\SQLEXPRESS;Initial Catalog=SQLBANHANG;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tb = new DataTable();
        void loadData()
        {
            ///
            voidLick();
            ///
            
            cmd = conn.CreateCommand();
            cmd.CommandText = "select HOADON.SOHD,KHACHHANG.MAKH, SANPHAM.MASP,SANPHAM.TENSP,CTHD.SL,CTHD.DONGIA,CTHD.GIAM as [GIAM %],CTHD.THANHTIEN  from SANPHAM,CTHD,KHACHHANG,HOADON where SANPHAM.MASP = CTHD.MASP and CTHD.SOHD = HOADON.SOHD and KHACHHANG.MAKH = HOADON.MAKH group by HOADON.SOHD,KHACHHANG.MAKH,SANPHAM.MASP,SANPHAM.TENSP,CTHD.SL,CTHD.DONGIA,CTHD.GIAM,CTHD.THANHTIEN";
            adapter.SelectCommand = cmd;
            tb.Clear();
            adapter.Fill(tb);
            dataGridView1.DataSource = tb;
        }
        void loadDonHang()
        {
            ///
            voidLick();
            ///
             cmd = conn.CreateCommand();
             cmd.CommandText = "select CTHD.SOHD,KHACHHANG.MAKH, KHACHHANG.HOTEN , KHACHHANG.SODT,KHACHHANG.DCHI, SANPHAM.TENSP, CTHD.DONGIA,CTHD.SL,CTHD.THANHTIEN,sum(CTHD.NO) as [Tong No] from CTHD, HOADON, SANPHAM, KHACHHANG  where KHACHHANG.MAKH = HOADON.MAKH  and HOADON.SOHD = CTHD.SOHD and CTHD.MASP = SANPHAM.MASP group by CTHD.SOHD,KHACHHANG.MAKH, KHACHHANG.HOTEN , KHACHHANG.SODT,KHACHHANG.DCHI, SANPHAM.TENSP, CTHD.DONGIA,CTHD.SL,CTHD.THANHTIEN";
             adapter.SelectCommand = cmd;
             tb.Clear();
             adapter.Fill(tb);
             dataGridView1.DataSource = tb;


        }

        private void voidLick()
        {
            if (lick == 1)
            {
                ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ThaiDuong/OneDrive/Máy tính/DoAn/iconTrangChu.png");
            }
            else if (lick == 2)
            {
                ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ThaiDuong/OneDrive/Máy tính/DoAn/iConGioHang.png");
            }
            else if (lick == 3)
            {
                ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ThaiDuong/OneDrive/Máy tính/DoAn/iConTag.jfif");
            }
            else if (lick == 4)
            {
                ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ThaiDuong/OneDrive/Máy tính/DoAn/iConThongKe.png");
            }
        }

        static int bienTien = 0;
        SQLBANHANGEntities3 qlbh = new SQLBANHANGEntities3();
        private void Main_Load(object sender, EventArgs e)
        {
            
            conn = new SqlConnection(str);
            conn.Open();
            loadData();
            //////
            lbTime.Text = ""+DateTime.Now;
            
           // btTimKiem.Hide();
            
            SqlCommand cmd = new SqlCommand();
        }
        
        private void pnTrangChu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnTrangChu_MouseHover(object sender, EventArgs e)
        {
        }

        private void pnTrangChu_MouseMove(object sender, MouseEventArgs e)
        {
            lbTrangChu.BackColor = Color.Fuchsia;
            lbTrangChu.ForeColor = Color.Yellow;
            pnTrangChu.BackColor = Color.Fuchsia;
            ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ASUS/Desktop/DoAn/iconTrangChu.png");
        }

        private void pnTrangChu_MouseLeave(object sender, EventArgs e)
        {
            lbTrangChu.BackColor = Color.Transparent;
            lbTrangChu.ForeColor = Color.Transparent;
            pnTrangChu.BackColor = Color.Transparent;
            if (lick == 0)
            {
                ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ASUS/Desktop/DoAn/lgHuTech.png");
            }
            voidLick();

        }

        private void lbTrangChu_MouseMove(object sender, MouseEventArgs e)
        {
            lbTrangChu.BackColor = Color.Fuchsia;
            lbTrangChu.ForeColor = Color.Yellow;
            pnTrangChu.BackColor = Color.Fuchsia;
            ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ASUS/Desktop/DoAn/iconTrangChu.png");
        }

        private void lbTrangChu_MouseLeave(object sender, EventArgs e)
        {
            
            lbTrangChu.BackColor = Color.Transparent;
            lbTrangChu.ForeColor = Color.Transparent; 
            pnTrangChu.BackColor = Color.Transparent;
            if(lick ==0 )
            {
                ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ASUS/Desktop/DoAn/lgHuTech.png");
            }
            voidLick();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbTrangChu_Click(object sender, EventArgs e)
        {
            
            lbTrangThai.Text = "Bán Hàng";
            hide();
            textBox1.Show();
            btTimKiem.Show();
            lbtiemKiem.Show();
            loadData();
            hienTrangChu();
            
            lick = 1;
            loadData();
        }

        private void hienTrangChu()
        {
            dataGridView1.Height = 250-btThanhToan.Height;
            dataGridView1.Width = 389;
            
            lbSoHoaDon.Show(); tbSoHoaDon.Show();
            lbMaSanPham.Show(); tbMaSanPham.Show();
            lbSoLuong.Show(); numberSL.Show();
            lbDiscount.Show(); tbDiscount.Show();
            lbThanhTien.Show(); tbThanhTien.Show();
            lbDonGia.Show(); tbDonGia.Show();
            btXem.Show(); btThanhToan.Show();  btXoa.Show(); btSua.Show();
            loadData();
            dataGridView1.Show();
            label1.Show();
            tbMaKH.Show();
            lbtiemKiem.Text = "SO HD";
        }
        private void pnDonHang_MouseMove(object sender, MouseEventArgs e)
        {
            lbDonHang.BackColor = Color.Fuchsia;
            lbDonHang.ForeColor = Color.Yellow;
            pnDonHang.BackColor = Color.Fuchsia;
            ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ASUS/Desktop/DoAn/iConGioHang.png");
        }

        private void pnDonHang_MouseLeave(object sender, EventArgs e)
        {
            lbDonHang.BackColor = Color.Transparent;
            lbDonHang.ForeColor = Color.Transparent;
            pnDonHang.BackColor = Color.Transparent;
            if (lick == 0)
            {
                ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ASUS/Desktop/DoAn/lgHuTech.png");
            }
            voidLick();
        }

        private void lbDonHang_MouseMove(object sender, MouseEventArgs e)
        {
            lbDonHang.BackColor = Color.Fuchsia;
            lbDonHang.ForeColor = Color.Yellow;
            pnDonHang.BackColor = Color.Fuchsia;
            ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ASUS/Desktop/DoAn/iConGioHang.png");
        }

        private void lbDonHang_MouseLeave(object sender, EventArgs e)
        {
            lbDonHang.BackColor = Color.Transparent;
            lbDonHang.ForeColor = Color.Transparent;
            pnDonHang.BackColor = Color.Transparent;
            if(lick ==0)
            {
                ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ASUS/Desktop/DoAn/lgHuTech.png");
            }
            voidLick();
        }
        private void pnSanPham_MouseMove(object sender, MouseEventArgs e)
        {
            lbSanPham.BackColor = Color.Fuchsia;
            lbSanPham.ForeColor = Color.Yellow;
            pnSanPham.BackColor = Color.Fuchsia;
            ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ASUS/Desktop/DoAn/iConTag.jfif");
        }

        private void pnSanPham_MouseLeave(object sender, EventArgs e)
        {
            lbSanPham.BackColor = Color.Transparent;
            lbSanPham.ForeColor = Color.Transparent;
            pnSanPham.BackColor = Color.Transparent;
            if (lick == 0)
            {
                ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ASUS/Desktop/DoAn/lgHuTech.png");
            }
            voidLick();
        }
        private void lbSanPham_MouseMove(object sender, MouseEventArgs e)
        {

            lbSanPham.BackColor = Color.Fuchsia;
            lbSanPham.ForeColor = Color.Yellow;
            pnSanPham.BackColor = Color.Fuchsia;
            ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ASUS/Desktop/DoAn/iConTag.jfif");
        }

        private void lbSanPham_MouseLeave(object sender, EventArgs e)
        {
            lbSanPham.BackColor = Color.Transparent;
            lbSanPham.ForeColor = Color.Transparent;
            pnSanPham.BackColor = Color.Transparent;
            if(lick == 0)
            {
                ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ASUS/Desktop/DoAn/lgHuTech.png");
            }
            voidLick();
        }
        private void pnThongke_MouseMove(object sender, MouseEventArgs e)
        {
            lbThongKe.BackColor = Color.Fuchsia;
            lbThongKe.ForeColor = Color.Yellow;
            pnThongKe.BackColor = Color.Fuchsia;
            ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ASUS/Desktop/DoAn/iConThongKe.png");
        }
        private void lbThongKe_MouseMove(object sender, MouseEventArgs e)
        {
            lbThongKe.BackColor = Color.Fuchsia;
            lbThongKe.ForeColor = Color.Yellow;
            pnThongKe.BackColor = Color.Fuchsia;
            ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ASUS/Desktop/DoAn/iConThongKe.png");
        }

        private void lbThongKe_MouseLeave(object sender, EventArgs e)
        { 
            lbThongKe.BackColor = Color.Transparent;
            lbThongKe.ForeColor = Color.Transparent;
            pnThongKe.BackColor = Color.Transparent;
            if (lick == 0)
            {
                ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ASUS/Desktop/DoAn/lgHuTech.png");
            }
            voidLick();
        }

        public delegate void truyenThanhToan(string text);
        public truyenThanhToan truyenTien;
        bool kiemtraThanhToan()
        {
            return true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if(kiemTraSoHoaDon() == true)
            {
                if (tbSoHoaDon.Text == "" || tbMaSanPham.Text == "")
                {
                    MessageBox.Show("Khong The Thanh Toan! ");
                }
                else
                {
                    thanhToan.SoHoaDon = tbSoHoaDon.Text;
                    thanhToan.TienThanhToan = tbThanhTien.Text;
                    thanhToan.MaKhachHang = tbMaKH.Text;
                    thanhToan.MaSP = tbMaSanPham.Text;
                    thanhToan.SoLuong = (numberSL.Value).ToString();
                    thanhToan.DonGia = tbDonGia.Text;
                    thanhToan.DisCount = tbDiscount.Text;
                    //////
                    thanhToan TT = new thanhToan();

                    this.Hide();
                    TT.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Hoa don da thanh toan!");
            }



            ////
            ///
            
        }

        private bool kiemTraSoHoaDon()
        {

            var hd = (from c in qlbh.CTHDs
                      where tbSoHoaDon.Text == c.SOHD.ToString()
                      select c).SingleOrDefault();


            if (hd == null)

                return true;
            else
                return false;
            }

        private void lbDonHang_Click(object sender, EventArgs e)
        {
            lbTrangThai.Text = "Xem Hóa Đơn";
            hide();
            hienDonHang();
            /*Button btTiemKiem = new Button();
            btTiemKiem.Name = "btTimKiem";
            btTiemKiem.Text = "Tiem Kiem";
            btTiemKiem.AutoSize = true;
            var point = new Point(60, 52);
            btTiemKiem.Location = point;
            this.Controls.Add(btTiemKiem);
            btTiemKiem.Show();*/
            lick = 2;
        }

        private void hienDonHang()
        {

            
            dataGridView1.Show();
            dataGridView1.Height = 230;
            dataGridView1.Width = 600;
            lbtiemKiem.Text = "Tim kiem theo SDT khach hang | Ten khach hang ";
            textBox1.Show();
            lbtiemKiem.Show();
            this.btTimKiem.Show();
            loadDonHang();
        }
            private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("bạn c chắc muốn thoát !", "Có Không", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
            {
                this.Close();
                
            }
        }
        int tam;
        private void lbThongKe_Click(object sender, EventArgs e)
        {
           
           /* 
            var ketqua = from c in qlbh.CTHDs
                         where c.SOHD
                         select c;
           
            qlbh.CTHDs.Remove(ketqua.SingleOrDefault());*/
            qlbh.SaveChanges();
            lbTrangThai.Text = "Xem Thống Kê";
            hide();
            showThongKe();
            var hd = (from c in qlbh.CTHDs
                      select c.SOHD).Count();
            tam = hd;
            lick = 4;
        }

        PictureBox ptbHoaDon = new PictureBox();
        PictureBox ptbSanPham = new PictureBox();
        PictureBox ptbDanhSo = new PictureBox();
        PictureBox ptbKho = new PictureBox();
        PictureBox ptbLoai = new PictureBox();
        PictureBox ptbNo = new PictureBox();
        private void showThongKe()
        {
           ////////////////// ////////////////////////////////
            Label lbHoaDon = new Label();
            lbHoaDon.AutoSize = true;
            lbHoaDon.Font = new Font(lbHoaDon.Font.FontFamily, 15); 
            lbHoaDon.Text = "Hoa Don / (Thang) ";
            lbHoaDon.AllowDrop = true;
            ptbHoaDon.Controls.Add(lbHoaDon);
            ///
            var hd = (from c in qlbh.CTHDs
                     
                      select c.SOHD).Count();
            var pointshd = new Point(15, 25);
            Label lbshd = new Label();
            lbshd.AutoSize = true;
            lbshd.Text = hd.ToString()+" HD";
            lbshd.Font = new Font(lbshd.Font.FontFamily, 40,FontStyle.Bold);
            lbshd.Location = pointshd;
            ptbHoaDon.Controls.Add(lbshd);



            
            var point = new Point(5, 15);
            ptbHoaDon.Location = point;
            ptbHoaDon.Width = 205;
            ptbHoaDon.Height = 120;
            ptbHoaDon.BackColor = Color.Yellow;
            ptbHoaDon.Name = "ptbHoaDon";
            pnMain.Controls.Add(ptbHoaDon);
            ptbHoaDon.Show();
            /////////////////////////////////////////////////////

            Label lbSanPham = new Label();
            lbSanPham.AutoSize = true;
            lbSanPham.Text = "\tMat Hang(Thang) ";
            lbSanPham.Font = new Font(lbSanPham.Font.FontFamily, 15);
            lbSanPham.AllowDrop = true;
           
            ptbSanPham.Controls.Add(lbSanPham);
            ///
            var sp = ((from c in qlbh.CTHDs
                       
                       select c.MASP).Distinct()).Count();

            var pointsp = new Point(15, 25);
            Label lbsp = new Label();
            lbsp.AutoSize = true;
            lbsp.Text = sp.ToString() + " MH";
            lbsp.Font = new Font(lbsp.Font.FontFamily, 40, FontStyle.Bold);
            lbsp.Location = pointsp;
            ptbSanPham.Controls.Add(lbsp);
            //


            var point1 = new Point(215,15);
            ptbSanPham.Location = point1;
            ptbSanPham.Width = 205;
            ptbSanPham.Height = 120;
            ptbSanPham.BackColor = Color.Blue;
            ptbSanPham.Name = "ptbSanPham";
            pnMain.Controls.Add(ptbSanPham);
            ptbSanPham.Show();
            ///////////////////////////////////////////////////////////////////////
            Label lbDoanhSo = new Label();
            lbDoanhSo.AutoSize = true;
            lbDoanhSo.Text = "\tDanh So(Thang) "; lbDoanhSo.Font = new Font(lbDoanhSo.Font.FontFamily, 15);
            lbDoanhSo.AllowDrop = true;
           
            ptbDanhSo.Controls.Add(lbDoanhSo);
            //
            var ds = (from c in qlbh.CTHDs
                      select c.THANHTIEN).Sum();

            var pointds = new Point(15, 25);
            Label lbds = new Label();
            lbds.AutoSize = true;
            lbds.Text = ds.ToString()+"\n  VND";
            lbds.Font = new Font(lbds.Font.FontFamily, 20, FontStyle.Bold);
            lbds.Location = pointds;
            ptbDanhSo.Controls.Add(lbds);
            //


            var point2 = new Point(425,15);
            ptbDanhSo.Location = point2;
            ptbDanhSo.Width = 205;
            ptbDanhSo.Height = 120;
            ptbDanhSo.BackColor = Color.Green;
            ptbDanhSo.Name = "ptbDanhSo";
            pnMain.Controls.Add(ptbDanhSo);
            ptbDanhSo.Show();
            /////////////////////////////////////////////////////////////////////
            Label lbKho = new Label();
            lbKho.AutoSize = true;
            lbKho.Text = "Tong SP Trong Kho"; lbKho.Font = new Font(lbKho.Font.FontFamily, 15);
            lbKho.AllowDrop = true;
            
            ptbKho.Controls.Add(lbKho);
            
            var kho = ((from c in qlbh.SANPHAMs
                       select c.CONLAI).Distinct()).Sum();

            var pointkho = new Point(15, 25);
            Label lbkho = new Label();
            lbkho.AutoSize = true;
            lbkho.Text = kho.ToString() + " SP";
            lbkho.Font = new Font(lbkho.Font.FontFamily, 30, FontStyle.Bold);
            lbkho.Location = pointkho;
            ptbKho.Controls.Add(lbkho);

            //
            var point3 = new Point(5, 150);
            ptbKho.Location = point3;
            ptbKho.Width = 205;
            ptbKho.Height = 100;
            ptbKho.BackColor = Color.Pink;
            ptbKho.Name = "ptbKho";
            pnMain.Controls.Add(ptbKho);
            ptbKho.Show();
            ///////////////////////////////////////////////////////////////////////
            Label lbLoai = new Label();
            lbLoai.AutoSize = true;
            lbLoai.Text = "Loai SP Trong Kho"; lbLoai.Font = new Font(lbLoai.Font.FontFamily, 15);
            lbLoai.AllowDrop = true;
            
            ptbLoai.Controls.Add(lbLoai);
            //
            var loai = ((from c in qlbh.SANPHAMs
                        select c.CONLAI).Distinct()).Count();

            var pointloai = new Point(15, 25);
            Label lbloai = new Label();
            lbloai.AutoSize = true;
            lbloai.Text = loai.ToString() + " loai";
            lbloai.Font = new Font(lbloai.Font.FontFamily, 40, FontStyle.Bold);
            lbloai.Location = pointloai;
            ptbLoai.Controls.Add(lbloai);
            //
            var point4 = new Point(215, 150);
            ptbLoai.Location = point4;
            ptbLoai.Width = 205;
            ptbLoai.Height = 100;
            ptbLoai.BackColor = Color.Gray;
            ptbLoai.Name = "ptbLoai";
            pnMain.Controls.Add(ptbLoai);
            ptbLoai.Show();
            /////////////////////////////////////////////////////////////////////
            Label lbNo = new Label();
            lbNo.AutoSize = true;
            lbNo.Text = "Tong Tien Khach No"; lbNo.Font = new Font(lbNo.Font.FontFamily, 15);
            lbNo.AllowDrop = true;
            ptbNo.Controls.Add(lbNo);

            //
            var No = ((from c in qlbh.CTHDs
                       select c.NO)).Sum();

            var pointN = new Point(10, 35);
            Label lbN = new Label();
            lbN.AutoSize = true;
            lbN.Text = No.ToString() + "VND";
            lbN.Font = new Font(lbN.Font.FontFamily, 23, FontStyle.Bold);
            lbN.Location = pointN;
            ptbNo.Controls.Add(lbN);
            ///
            var point5 = new Point(425, 150);
            ptbNo.Location = point5;
            ptbNo.Width = 205;
            ptbNo.Height = 100;
            ptbNo.BackColor = Color.Orange;
            ptbNo.Name = "ptbNo";
            pnMain.Controls.Add(ptbNo);
            ptbNo.Show();
            /////////////////////////////////////////////////////////////
        }

        private void hide()
        {

            /*dataGridView1.Height = 230;
            dataGridView1.Width = 600;*/
            lbSoHoaDon.Hide(); tbSoHoaDon.Hide();
            lbMaSanPham.Hide(); tbMaSanPham.Hide();
            lbSoLuong.Hide(); numberSL.Hide();
            lbDiscount.Hide(); tbDiscount.Hide();
            lbThanhTien.Hide(); tbThanhTien.Hide();
            lbDonGia.Hide(); tbDonGia.Hide();
            btXem.Hide(); btThanhToan.Hide(); btXoa.Hide(); btSua.Hide();
            tbMaKH.Hide();
            label1.Hide();
            btTimKiem.Hide();
            textBox1.Hide();
            dataGridView1.Hide();
            lbtiemKiem.Hide();
            ptbHoaDon.Hide();ptbDanhSo.Hide();ptbKho.Hide();ptbLoai.Hide();ptbNo.Hide();ptbSanPham.Hide();
            
        }

        private void lbSanPham_Click(object sender, EventArgs e)
        {
            lbTrangThai.Text = "Sản Phẩm";
            hide();
            lick = 3;
            hienSanPham();
            dataGridView1.Show();
        }

        private void hienSanPham()
        {
            tbSoHoaDon.Show();
            tbMaSanPham.Show();
            tbDiscount.Show();
            tbMaKH.Show();
            tbDonGia.Show();
            tbThanhTien.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            tbSoHoaDon.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tbMaKH.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tbMaSanPham.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            numberSL.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            tbDonGia.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            tbDiscount.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            tbThanhTien.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            
            

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            addBill();

        }

        private void addBill()
        {
            {
                if (tbSoHoaDon.Text == "" || tbMaSanPham.Text == "")
                {
                    MessageBox.Show("Them That Bai! ");
                }
                else
                {
                    loadData();
                    int SHD = Convert.ToInt32(tbSoHoaDon.Text);
                    int SL = Convert.ToInt32(numberSL.Value);
                    int DG = Convert.ToInt32(tbDonGia.Text);
                    int TT = Convert.ToInt32(tbThanhTien.Text);
                    int G = Convert.ToInt32(tbDiscount.Text);




                    qlbh.HOADONs.Add(new HOADON() { SOHD = SHD });

                    qlbh.SaveChanges();


                    CTHD chiTietHoaDon = new CTHD()
                    {
                        SOHD = SHD,
                        MASP = tbMaSanPham.Text,
                        SL = SL,
                        DONGIA = DG,
                        THANHTIEN = TT,
                        GIAM = G,
                    };


                    qlbh.CTHDs.Add(chiTietHoaDon);
                    qlbh.SaveChanges();



                }

            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Tiem Kiem That Bai! ");
            }
            else
            {
                int tk = Convert.ToInt32(textBox1.Text);
                var ketqua = from c in qlbh.CTHDs
                             where c.SOHD == tk
                             select c;
                dataGridView1.DataSource = ketqua.ToList();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btHuyTK_Click(object sender, EventArgs e)
        {
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Xoa That Bai! ");
            }
            else
            {

                int tk = Convert.ToInt32(textBox1.Text);

                var kq = from c in qlbh.HOADONs
                         where c.SOHD == tk
                         select c;

                var ketqua = from c in qlbh.CTHDs
                             where c.SOHD == tk
                             select c;
                qlbh.HOADONs.Remove(kq.SingleOrDefault());
                qlbh.CTHDs.Remove(ketqua.SingleOrDefault());
                qlbh.SaveChanges();
                MessageBox.Show("Xoa Thanh Cong ");
            }
        }

        private void lbXem_Click(object sender, EventArgs e)
        {

            loadData();
            textBox1.Clear();
        }

        bool choCapNhat()
        {
            int sohoadon = Convert.ToInt32(tbSoHoaDon.Text);
            var m = from c in qlbh.CTHDs
                    where c.SOHD == sohoadon
                    select c.SOHD;


            if (m != null)
                return true;
            else
                return false;
                    
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            if(choCapNhat()==true)
            {
                capnhat();
            }
            else
            {
                MessageBox.Show("cap nhat that bai!");
            }


            /*if(tbSoHoaDon.Text==""||tbMaSanPham.Text=="")
            {
                MessageBox.Show("Sua That Bai! ");
            }
            else
            {
                int SHD = Convert.ToInt32(tbSoHoaDon.Text);
                int SL = Convert.ToInt32(numberSL.Value);
                int DG = Convert.ToInt32(tbDonGia.Text);
                int TT = Convert.ToInt32(tbThanhTien.Text);
                int id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["SOHD"].Value.ToString());
                CTHD ct = qlbh.CTHDs.Find(id);
                ct.SOHD = SHD;
                ct.MASP = tbMaSanPham.Text;
                ct.SL = SL;
                ct.DONGIA = DG;
                ct.THANHTIEN = TT;
                qlbh.SaveChanges();
            }*/

        }

        private void capnhat()
        {
            
            DateTime dt = DateTime.Now;
            int SHD = Convert.ToInt32(tbSoHoaDon.Text);
            var hd = (from c in qlbh.HOADONs
                     where c.SOHD == SHD
                     select c).SingleOrDefault();
            var shd = (from c in qlbh.CTHDs
                       where c.SOHD == SHD
                       select c).SingleOrDefault();
            if(shd==null)
            {
                MessageBox.Show("Sua That Bai!");
            }
            else
            {
                int sl = Convert.ToInt32(numberSL.Value);
                int dg = Convert.ToInt32(tbDonGia.Text);
                int tt = Convert.ToInt32(tbThanhTien.Text);
                int g = Convert.ToInt32(tbDiscount.Text);
                qlbh.HOADONs.Remove(hd);
                qlbh.CTHDs.Remove(shd);
                qlbh.SaveChanges();
                HOADON hoadon = new HOADON()
                {
                    SOHD = SHD,
                    NGHD = dt,
                    MAKH = tbMaKH.Text,

                };
                //qlbh.HOADONs.Add(hd);


                CTHD chiTietHoaDon = new CTHD()
                {
                    SOHD = SHD,
                    MASP = tbMaSanPham.Text,
                    SL = sl,
                    DONGIA = dg,
                    THANHTIEN = tt,
                    GIAM = g,



                };
                qlbh.HOADONs.Add(hoadon);
                qlbh.CTHDs.Add(chiTietHoaDon);
                qlbh.SaveChanges();
                MessageBox.Show("Sua Thanh Cong ");
            }
            
        }

        int sl = 0; int dongia = 0; int giam = 0;
        private void numberSL_ValueChanged(object sender, EventArgs e)
        {
            
            sl = Convert.ToInt32(numberSL.Value);
            textChange();
        }

        private void tbDonGia_TextChanged(object sender, EventArgs e)
        {
            if (tbDonGia.Text == "")
                dongia = 0;
            else
            { 
                dongia = Convert.ToInt32(tbDonGia.Text);
                textChange();
            }
           
        }

        private void tbDiscount_TextChanged(object sender, EventArgs e)
        {
            if (tbDiscount.Text == "")
                giam = 0;
            else
            {
                giam = Convert.ToInt32(tbDiscount.Text);
                textChange();
            }
           
        }
        int tien;
        public void textChange()
        {
            if (giam == 0 || tbDiscount.Text == "")
            {
                tien = (sl * dongia);
                tbThanhTien.Text = tien.ToString();
            }
            else if(dongia ==0 || tbDiscount.Text =="")
            {
                tien = 0;
                tbThanhTien.Text = tien.ToString();
            }
            else if(sl==0)
            {
                tien = 0;
                tbThanhTien.Text = tien.ToString();
            }
            else
            {
                tien = (sl * dongia) - ((sl * dongia * giam) / 100);
                tbThanhTien.Text = tien.ToString();
            }
        }

        private void pnThongKe_MouseLeave(object sender, EventArgs e)
        {
            lbThongKe.BackColor = Color.Transparent;
            lbThongKe.ForeColor = Color.Transparent;
            pnThongKe.BackColor = Color.Transparent;
            if (lick == 0)
            {
                ptbLoGo.BackgroundImage = Image.FromFile("C:/Users/ASUS/Desktop/DoAn/lgHuTech.png");
            }
            voidLick();
            if (lick==0)
            { }
        }

        private void pnThongKe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnDonHang_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
