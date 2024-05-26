namespace QLCHUYENBAY
{
    partial class FormChuongTrinh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_MaChuyenBay = new System.Windows.Forms.TextBox();
            this.cbb_SanBayDi = new System.Windows.Forms.ComboBox();
            this.cbb_SanBayDen = new System.Windows.Forms.ComboBox();
            this.txb_ThoiGianBay = new System.Windows.Forms.TextBox();
            this.txb_SoGheVip = new System.Windows.Forms.TextBox();
            this.txb_SoGheThuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtime_NgayBay = new System.Windows.Forms.DateTimePicker();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chuyến bay";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 21);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(652, 215);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chuyến bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sân bay đi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.dtime_NgayBay);
            this.groupBox2.Controls.Add(this.cbb_SanBayDen);
            this.groupBox2.Controls.Add(this.cbb_SanBayDi);
            this.groupBox2.Controls.Add(this.txb_SoGheThuong);
            this.groupBox2.Controls.Add(this.txb_SoGheVip);
            this.groupBox2.Controls.Add(this.txb_ThoiGianBay);
            this.groupBox2.Controls.Add(this.txb_MaChuyenBay);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sân bay đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thời gian bay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số ghế VIP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày bay";
            // 
            // txb_MaChuyenBay
            // 
            this.txb_MaChuyenBay.Location = new System.Drawing.Point(107, 28);
            this.txb_MaChuyenBay.Name = "txb_MaChuyenBay";
            this.txb_MaChuyenBay.Size = new System.Drawing.Size(144, 22);
            this.txb_MaChuyenBay.TabIndex = 1;
            // 
            // cbb_SanBayDi
            // 
            this.cbb_SanBayDi.FormattingEnabled = true;
            this.cbb_SanBayDi.Items.AddRange(new object[] {
            "Nội Bài",
            "Tân Sơn Nhất",
            "Vân Đồn",
            "Đà Nẵng",
            "Phú Quốc",
            "Cát Bi",
            "Phú Bài"});
            this.cbb_SanBayDi.Location = new System.Drawing.Point(107, 65);
            this.cbb_SanBayDi.Name = "cbb_SanBayDi";
            this.cbb_SanBayDi.Size = new System.Drawing.Size(144, 23);
            this.cbb_SanBayDi.TabIndex = 2;
            // 
            // cbb_SanBayDen
            // 
            this.cbb_SanBayDen.FormattingEnabled = true;
            this.cbb_SanBayDen.Items.AddRange(new object[] {
            "Nội Bài",
            "Tân Sơn Nhất",
            "Vân Đồn",
            "Đà Nẵng",
            "Phú Quốc",
            "Cát Bi",
            "Phú Bài"});
            this.cbb_SanBayDen.Location = new System.Drawing.Point(107, 104);
            this.cbb_SanBayDen.Name = "cbb_SanBayDen";
            this.cbb_SanBayDen.Size = new System.Drawing.Size(144, 23);
            this.cbb_SanBayDen.TabIndex = 2;
            // 
            // txb_ThoiGianBay
            // 
            this.txb_ThoiGianBay.Location = new System.Drawing.Point(354, 28);
            this.txb_ThoiGianBay.Name = "txb_ThoiGianBay";
            this.txb_ThoiGianBay.Size = new System.Drawing.Size(144, 22);
            this.txb_ThoiGianBay.TabIndex = 1;
            // 
            // txb_SoGheVip
            // 
            this.txb_SoGheVip.Location = new System.Drawing.Point(354, 66);
            this.txb_SoGheVip.Name = "txb_SoGheVip";
            this.txb_SoGheVip.Size = new System.Drawing.Size(144, 22);
            this.txb_SoGheVip.TabIndex = 1;
            // 
            // txb_SoGheThuong
            // 
            this.txb_SoGheThuong.Location = new System.Drawing.Point(354, 104);
            this.txb_SoGheThuong.Name = "txb_SoGheThuong";
            this.txb_SoGheThuong.Size = new System.Drawing.Size(144, 22);
            this.txb_SoGheThuong.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số ghế thường";
            // 
            // dtime_NgayBay
            // 
            this.dtime_NgayBay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtime_NgayBay.Location = new System.Drawing.Point(107, 148);
            this.dtime_NgayBay.Name = "dtime_NgayBay";
            this.dtime_NgayBay.Size = new System.Drawing.Size(144, 22);
            this.dtime_NgayBay.TabIndex = 3;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(258, 148);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 37);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(339, 148);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 37);
            this.btn_Sua.TabIndex = 4;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(423, 148);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 37);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(525, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 184);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng thêm";
            // 
            // FormChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormChuongTrinh";
            this.Text = "Quản lý chuyến bay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChuongTrinh_FormClosed);
            this.Load += new System.EventHandler(this.FormChuongTrinh_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_SanBayDen;
        private System.Windows.Forms.ComboBox cbb_SanBayDi;
        private System.Windows.Forms.TextBox txb_MaChuyenBay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_SoGheThuong;
        private System.Windows.Forms.TextBox txb_SoGheVip;
        private System.Windows.Forms.TextBox txb_ThoiGianBay;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DateTimePicker dtime_NgayBay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}