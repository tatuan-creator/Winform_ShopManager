
namespace QuanLyBanHang
{
    partial class thanhToan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbThanhToan = new System.Windows.Forms.TextBox();
            this.btHuy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btDongY = new System.Windows.Forms.Button();
            this.bt50 = new System.Windows.Forms.Button();
            this.bt100 = new System.Windows.Forms.Button();
            this.bt200 = new System.Windows.Forms.Button();
            this.bt500 = new System.Windows.Forms.Button();
            this.btTraDu = new System.Windows.Forms.Button();
            this.btNo = new System.Windows.Forms.Button();
            this.tbTienThoi = new System.Windows.Forms.TextBox();
            this.tbTIenNhap = new System.Windows.Forms.TextBox();
            this.lbSoHoaDon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanh Toán";
            // 
            // tbThanhToan
            // 
            this.tbThanhToan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThanhToan.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbThanhToan.Location = new System.Drawing.Point(207, 39);
            this.tbThanhToan.Multiline = true;
            this.tbThanhToan.Name = "tbThanhToan";
            this.tbThanhToan.Size = new System.Drawing.Size(240, 36);
            this.tbThanhToan.TabIndex = 1;
            this.tbThanhToan.TextChanged += new System.EventHandler(this.tbThanhToan_TextChanged);
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.SystemColors.Info;
            this.btHuy.Location = new System.Drawing.Point(200, 381);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(126, 39);
            this.btHuy.TabIndex = 2;
            this.btHuy.Text = "Hủy ";
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách Đưa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiền Thối Lại";
            // 
            // btDongY
            // 
            this.btDongY.BackColor = System.Drawing.SystemColors.Info;
            this.btDongY.Location = new System.Drawing.Point(328, 381);
            this.btDongY.Name = "btDongY";
            this.btDongY.Size = new System.Drawing.Size(119, 39);
            this.btDongY.TabIndex = 2;
            this.btDongY.Text = "Đồng Ý";
            this.btDongY.UseVisualStyleBackColor = false;
            this.btDongY.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt50
            // 
            this.bt50.AutoSize = true;
            this.bt50.BackColor = System.Drawing.SystemColors.Info;
            this.bt50.Location = new System.Drawing.Point(207, 102);
            this.bt50.Name = "bt50";
            this.bt50.Size = new System.Drawing.Size(84, 35);
            this.bt50.TabIndex = 2;
            this.bt50.Text = "50.000";
            this.bt50.UseVisualStyleBackColor = false;
            this.bt50.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt100
            // 
            this.bt100.AutoSize = true;
            this.bt100.BackColor = System.Drawing.SystemColors.Info;
            this.bt100.Location = new System.Drawing.Point(365, 102);
            this.bt100.Name = "bt100";
            this.bt100.Size = new System.Drawing.Size(82, 35);
            this.bt100.TabIndex = 2;
            this.bt100.Text = "100.000";
            this.bt100.UseVisualStyleBackColor = false;
            this.bt100.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt200
            // 
            this.bt200.AutoSize = true;
            this.bt200.BackColor = System.Drawing.SystemColors.Info;
            this.bt200.Location = new System.Drawing.Point(207, 155);
            this.bt200.Name = "bt200";
            this.bt200.Size = new System.Drawing.Size(84, 35);
            this.bt200.TabIndex = 2;
            this.bt200.Text = "200.000";
            this.bt200.UseVisualStyleBackColor = false;
            this.bt200.Click += new System.EventHandler(this.button5_Click);
            // 
            // bt500
            // 
            this.bt500.AutoSize = true;
            this.bt500.BackColor = System.Drawing.SystemColors.Info;
            this.bt500.Location = new System.Drawing.Point(365, 155);
            this.bt500.Name = "bt500";
            this.bt500.Size = new System.Drawing.Size(82, 35);
            this.bt500.TabIndex = 2;
            this.bt500.Text = "500.000";
            this.bt500.UseVisualStyleBackColor = false;
            this.bt500.Click += new System.EventHandler(this.button6_Click);
            // 
            // btTraDu
            // 
            this.btTraDu.AutoSize = true;
            this.btTraDu.BackColor = System.Drawing.SystemColors.Info;
            this.btTraDu.Location = new System.Drawing.Point(207, 196);
            this.btTraDu.Name = "btTraDu";
            this.btTraDu.Size = new System.Drawing.Size(109, 46);
            this.btTraDu.TabIndex = 2;
            this.btTraDu.Text = "Trả Đủ";
            this.btTraDu.UseVisualStyleBackColor = false;
            this.btTraDu.Click += new System.EventHandler(this.button7_Click);
            // 
            // btNo
            // 
            this.btNo.AutoSize = true;
            this.btNo.BackColor = System.Drawing.SystemColors.Info;
            this.btNo.Location = new System.Drawing.Point(322, 196);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(125, 46);
            this.btNo.TabIndex = 2;
            this.btNo.Text = "Nợ";
            this.btNo.UseVisualStyleBackColor = false;
            this.btNo.Click += new System.EventHandler(this.button8_Click);
            // 
            // tbTienThoi
            // 
            this.tbTienThoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbTienThoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTienThoi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbTienThoi.Location = new System.Drawing.Point(200, 326);
            this.tbTienThoi.Multiline = true;
            this.tbTienThoi.Name = "tbTienThoi";
            this.tbTienThoi.Size = new System.Drawing.Size(247, 36);
            this.tbTienThoi.TabIndex = 1;
            this.tbTienThoi.TextChanged += new System.EventHandler(this.tbTienThoi_TextChanged);
            // 
            // tbTIenNhap
            // 
            this.tbTIenNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbTIenNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTIenNhap.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbTIenNhap.Location = new System.Drawing.Point(200, 248);
            this.tbTIenNhap.Multiline = true;
            this.tbTIenNhap.Name = "tbTIenNhap";
            this.tbTIenNhap.Size = new System.Drawing.Size(247, 32);
            this.tbTIenNhap.TabIndex = 1;
            this.tbTIenNhap.TextChanged += new System.EventHandler(this.tbTIenNhap_TextChanged);
            // 
            // lbSoHoaDon
            // 
            this.lbSoHoaDon.AutoSize = true;
            this.lbSoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoHoaDon.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbSoHoaDon.Location = new System.Drawing.Point(202, 9);
            this.lbSoHoaDon.Name = "lbSoHoaDon";
            this.lbSoHoaDon.Size = new System.Drawing.Size(96, 25);
            this.lbSoHoaDon.TabIndex = 3;
            this.lbSoHoaDon.Text = "Hoa Don";
            // 
            // thanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(501, 447);
            this.Controls.Add(this.lbSoHoaDon);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.bt500);
            this.Controls.Add(this.btTraDu);
            this.Controls.Add(this.bt200);
            this.Controls.Add(this.bt100);
            this.Controls.Add(this.bt50);
            this.Controls.Add(this.btDongY);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.tbTIenNhap);
            this.Controls.Add(this.tbTienThoi);
            this.Controls.Add(this.tbThanhToan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "thanhToan";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "thanhToan";
            this.Load += new System.EventHandler(this.thanhToan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbThanhToan;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDongY;
        private System.Windows.Forms.Button bt50;
        private System.Windows.Forms.Button bt100;
        private System.Windows.Forms.Button bt200;
        private System.Windows.Forms.Button bt500;
        private System.Windows.Forms.Button btTraDu;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.TextBox tbTienThoi;
        private System.Windows.Forms.TextBox tbTIenNhap;
        private System.Windows.Forms.Label lbSoHoaDon;
    }
}