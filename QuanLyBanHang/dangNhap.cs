using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace QuanLyBanHang
{
    public partial class dangNhap : Form
    {
       
        public dangNhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public class clsLogin
        {
           
            
            SqlCommand cmd;
            SqlDataReader dr;
            SqlDataAdapter MyDataAdapter = new SqlDataAdapter();
            public DataSet MyDataSet = new DataSet();

         
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {
           
            string chuoiketnoi = @"Data Source=DESKTOP-GISFHHL\SQLEXPRESS;Initial Catalog=SQLBANHANG;Integrated Security=True";

            SqlConnection ketnoi = new SqlConnection();

            ketnoi.ConnectionString = chuoiketnoi;

            ketnoi.Open();

            SqlCommand lenh = new SqlCommand();

            lenh.Connection = ketnoi;

            lenh.CommandText = string.Format("select count(*) from TAIKHOAN where TENTK ='{0}' and MATKHAU = '{1}'", tbTenTaiKhoan.Text, tbMatKhau.Text);

            int i = (Int32)lenh.ExecuteScalar();

            if (i > 0)
            {
                this.Focus();
                this.Hide();
                FormMain fm = new FormMain();
                fm.ShowDialog();
                this.Show();
               // MessageBox.Show("Đang nhập thành công");
            }
                

           


            else

                MessageBox.Show("Đang nhập thất bại");

            ketnoi.Close();







            
            /* if(tbTenTaiKhoan.Text==taikhoan.ToString()&&tbMatKhau.Text==matkhau.ToString())
             {
                 this.Focus();
                 this.Hide();
                 FormMain f = new FormMain();
                 f.ShowDialog();
                 this.Show();
             }
             else
             {
                 MessageBox.Show("tai khoan hoac mat khau khong dung!");
             }*/



        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dia  =  MessageBox.Show("bạn kó chắc muốn thoát !", "Có Không", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
            {
                this.Close();
            }
           
               
        }
    }
}
