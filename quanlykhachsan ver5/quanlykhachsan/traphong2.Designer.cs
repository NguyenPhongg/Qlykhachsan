namespace quanlykhachsan
{
    partial class traphong2
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
            this.components = new System.ComponentModel.Container();
            this.dgvthuephong = new System.Windows.Forms.DataGridView();
            this.mAPHIEUTHUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANHANVIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKHACHHANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYDENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYDIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAPHONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblphieuthuephongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlykhachsandemo2304DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlykhachsandemo2304DataSet = new quanlykhachsan.quanlykhachsandemo2304DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtNgayden = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNgaydi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTraphong = new System.Windows.Forms.Button();
            this.btnTinhtien = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtTKmaphieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaphieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataSet1 = new quanlykhachsan.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_phieuthuephongTableAdapter = new quanlykhachsan.quanlykhachsandemo2304DataSetTableAdapters.tbl_phieuthuephongTableAdapter();
            this.lbSongay = new System.Windows.Forms.Label();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTTHoadon = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.mAPHONGDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIAPHONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblphongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_phongTableAdapter = new quanlykhachsan.quanlykhachsandemo2304DataSetTableAdapters.tbl_phongTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthuephong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblphieuthuephongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblphongBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvthuephong
            // 
            this.dgvthuephong.AutoGenerateColumns = false;
            this.dgvthuephong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvthuephong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthuephong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAPHIEUTHUEDataGridViewTextBoxColumn,
            this.mANHANVIENDataGridViewTextBoxColumn,
            this.mAKHACHHANGDataGridViewTextBoxColumn,
            this.nGAYDENDataGridViewTextBoxColumn,
            this.nGAYDIDataGridViewTextBoxColumn,
            this.mAPHONGDataGridViewTextBoxColumn});
            this.dgvthuephong.DataSource = this.tblphieuthuephongBindingSource;
            this.dgvthuephong.Location = new System.Drawing.Point(33, 79);
            this.dgvthuephong.Name = "dgvthuephong";
            this.dgvthuephong.Size = new System.Drawing.Size(805, 188);
            this.dgvthuephong.TabIndex = 0;
            this.dgvthuephong.Click += new System.EventHandler(this.dgvthuephong_Click);
            // 
            // mAPHIEUTHUEDataGridViewTextBoxColumn
            // 
            this.mAPHIEUTHUEDataGridViewTextBoxColumn.DataPropertyName = "MAPHIEUTHUE";
            this.mAPHIEUTHUEDataGridViewTextBoxColumn.HeaderText = "MÃ PHIẾU THUÊ";
            this.mAPHIEUTHUEDataGridViewTextBoxColumn.Name = "mAPHIEUTHUEDataGridViewTextBoxColumn";
            // 
            // mANHANVIENDataGridViewTextBoxColumn
            // 
            this.mANHANVIENDataGridViewTextBoxColumn.DataPropertyName = "MANHANVIEN";
            this.mANHANVIENDataGridViewTextBoxColumn.HeaderText = "MÃ NV";
            this.mANHANVIENDataGridViewTextBoxColumn.Name = "mANHANVIENDataGridViewTextBoxColumn";
            // 
            // mAKHACHHANGDataGridViewTextBoxColumn
            // 
            this.mAKHACHHANGDataGridViewTextBoxColumn.DataPropertyName = "MAKHACHHANG";
            this.mAKHACHHANGDataGridViewTextBoxColumn.HeaderText = "MÃ KH";
            this.mAKHACHHANGDataGridViewTextBoxColumn.Name = "mAKHACHHANGDataGridViewTextBoxColumn";
            // 
            // nGAYDENDataGridViewTextBoxColumn
            // 
            this.nGAYDENDataGridViewTextBoxColumn.DataPropertyName = "NGAYDEN";
            this.nGAYDENDataGridViewTextBoxColumn.HeaderText = "NGÀY ĐẾN";
            this.nGAYDENDataGridViewTextBoxColumn.Name = "nGAYDENDataGridViewTextBoxColumn";
            // 
            // nGAYDIDataGridViewTextBoxColumn
            // 
            this.nGAYDIDataGridViewTextBoxColumn.DataPropertyName = "NGAYDI";
            this.nGAYDIDataGridViewTextBoxColumn.HeaderText = "NGÀY ĐI";
            this.nGAYDIDataGridViewTextBoxColumn.Name = "nGAYDIDataGridViewTextBoxColumn";
            // 
            // mAPHONGDataGridViewTextBoxColumn
            // 
            this.mAPHONGDataGridViewTextBoxColumn.DataPropertyName = "MAPHONG";
            this.mAPHONGDataGridViewTextBoxColumn.HeaderText = "MÃ PHÒNG";
            this.mAPHONGDataGridViewTextBoxColumn.Name = "mAPHONGDataGridViewTextBoxColumn";
            // 
            // tblphieuthuephongBindingSource
            // 
            this.tblphieuthuephongBindingSource.DataMember = "tbl_phieuthuephong";
            this.tblphieuthuephongBindingSource.DataSource = this.quanlykhachsandemo2304DataSetBindingSource;
            // 
            // quanlykhachsandemo2304DataSetBindingSource
            // 
            this.quanlykhachsandemo2304DataSetBindingSource.DataSource = this.quanlykhachsandemo2304DataSet;
            this.quanlykhachsandemo2304DataSetBindingSource.Position = 0;
            // 
            // quanlykhachsandemo2304DataSet
            // 
            this.quanlykhachsandemo2304DataSet.DataSetName = "quanlykhachsandemo2304DataSet";
            this.quanlykhachsandemo2304DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(301, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã KH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(393, 358);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(100, 20);
            this.txtMaKH.TabIndex = 2;
            // 
            // txtNgayden
            // 
            this.txtNgayden.Location = new System.Drawing.Point(680, 289);
            this.txtNgayden.Name = "txtNgayden";
            this.txtNgayden.ReadOnly = true;
            this.txtNgayden.Size = new System.Drawing.Size(100, 20);
            this.txtNgayden.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(603, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày đến";
            // 
            // txtNgaydi
            // 
            this.txtNgaydi.Location = new System.Drawing.Point(680, 323);
            this.txtNgaydi.Name = "txtNgaydi";
            this.txtNgaydi.ReadOnly = true;
            this.txtNgaydi.Size = new System.Drawing.Size(100, 20);
            this.txtNgaydi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(603, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày hiện tại";
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(680, 356);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.ReadOnly = true;
            this.txtMaphong.Size = new System.Drawing.Size(100, 20);
            this.txtMaphong.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(603, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã phòng";
            // 
            // btnTraphong
            // 
            this.btnTraphong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTraphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraphong.Location = new System.Drawing.Point(302, 471);
            this.btnTraphong.Name = "btnTraphong";
            this.btnTraphong.Size = new System.Drawing.Size(106, 27);
            this.btnTraphong.TabIndex = 9;
            this.btnTraphong.Text = "Trả phòng";
            this.btnTraphong.UseVisualStyleBackColor = false;
            this.btnTraphong.Click += new System.EventHandler(this.btnTraphong_Click);
            // 
            // btnTinhtien
            // 
            this.btnTinhtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTinhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhtien.Location = new System.Drawing.Point(449, 471);
            this.btnTinhtien.Name = "btnTinhtien";
            this.btnTinhtien.Size = new System.Drawing.Size(103, 27);
            this.btnTinhtien.TabIndex = 10;
            this.btnTinhtien.Text = "Tính tiền";
            this.btnTinhtien.UseVisualStyleBackColor = false;
            this.btnTinhtien.Click += new System.EventHandler(this.btnTinhtien_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btnTK);
            this.groupBox1.Controls.Add(this.txtTKmaphieu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(33, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 62);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm phiếu thuê";
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(580, 18);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(117, 27);
            this.btnTK.TabIndex = 12;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // txtTKmaphieu
            // 
            this.txtTKmaphieu.Location = new System.Drawing.Point(296, 20);
            this.txtTKmaphieu.Name = "txtTKmaphieu";
            this.txtTKmaphieu.Size = new System.Drawing.Size(213, 20);
            this.txtTKmaphieu.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhập mã phiếu thuê";
            // 
            // txtMaphieu
            // 
            this.txtMaphieu.Location = new System.Drawing.Point(393, 289);
            this.txtMaphieu.Name = "txtMaphieu";
            this.txtMaphieu.ReadOnly = true;
            this.txtMaphieu.Size = new System.Drawing.Size(100, 20);
            this.txtMaphieu.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(302, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã phiếu thuê";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(393, 324);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(302, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã nhân viên";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // tbl_phieuthuephongTableAdapter
            // 
            this.tbl_phieuthuephongTableAdapter.ClearBeforeFill = true;
            // 
            // lbSongay
            // 
            this.lbSongay.AutoSize = true;
            this.lbSongay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSongay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongay.ForeColor = System.Drawing.Color.Red;
            this.lbSongay.Location = new System.Drawing.Point(395, 393);
            this.lbSongay.Name = "lbSongay";
            this.lbSongay.Size = new System.Drawing.Size(2, 18);
            this.lbSongay.TabIndex = 17;
            // 
            // lbTongtien
            // 
            this.lbTongtien.AutoSize = true;
            this.lbTongtien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongtien.ForeColor = System.Drawing.Color.Red;
            this.lbTongtien.Location = new System.Drawing.Point(395, 429);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(2, 18);
            this.lbTongtien.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(302, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Số ngày ở";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(302, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tổng tiền";
            // 
            // btnTTHoadon
            // 
            this.btnTTHoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTTHoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTHoadon.Location = new System.Drawing.Point(578, 471);
            this.btnTTHoadon.Name = "btnTTHoadon";
            this.btnTTHoadon.Size = new System.Drawing.Size(128, 27);
            this.btnTTHoadon.TabIndex = 22;
            this.btnTTHoadon.Text = "Tạo HĐ thanh toán";
            this.btnTTHoadon.UseVisualStyleBackColor = false;
            this.btnTTHoadon.Click += new System.EventHandler(this.btnTTHoadon_Click);
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoGenerateColumns = false;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAPHONGDataGridViewTextBoxColumn1,
            this.gIAPHONGDataGridViewTextBoxColumn});
            this.dgvPhong.DataSource = this.tblphongBindingSource;
            this.dgvPhong.Location = new System.Drawing.Point(8, 19);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(213, 224);
            this.dgvPhong.TabIndex = 25;
            this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellContentClick);
            // 
            // mAPHONGDataGridViewTextBoxColumn1
            // 
            this.mAPHONGDataGridViewTextBoxColumn1.DataPropertyName = "MAPHONG";
            this.mAPHONGDataGridViewTextBoxColumn1.FillWeight = 101.5228F;
            this.mAPHONGDataGridViewTextBoxColumn1.HeaderText = "MÃ PHÒNG";
            this.mAPHONGDataGridViewTextBoxColumn1.Name = "mAPHONGDataGridViewTextBoxColumn1";
            // 
            // gIAPHONGDataGridViewTextBoxColumn
            // 
            this.gIAPHONGDataGridViewTextBoxColumn.DataPropertyName = "GIAPHONG";
            this.gIAPHONGDataGridViewTextBoxColumn.FillWeight = 98.47717F;
            this.gIAPHONGDataGridViewTextBoxColumn.HeaderText = "GIÁ/NGÀY";
            this.gIAPHONGDataGridViewTextBoxColumn.Name = "gIAPHONGDataGridViewTextBoxColumn";
            // 
            // tblphongBindingSource
            // 
            this.tblphongBindingSource.DataMember = "tbl_phong";
            this.tblphongBindingSource.DataSource = this.quanlykhachsandemo2304DataSet;
            // 
            // tbl_phongTableAdapter
            // 
            this.tbl_phongTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPhong);
            this.groupBox2.Location = new System.Drawing.Point(33, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 253);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giá phòng";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(732, 471);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 27);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(680, 390);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(100, 20);
            this.txtGia.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(603, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Giá";
            // 
            // traphong2
            // 
            this.AcceptButton = this.btnTK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(863, 538);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTTHoadon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbTongtien);
            this.Controls.Add(this.lbSongay);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaphieu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTinhtien);
            this.Controls.Add(this.btnTraphong);
            this.Controls.Add(this.txtMaphong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNgaydi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNgayden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvthuephong);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "traphong2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn";
            this.Load += new System.EventHandler(this.traphong2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthuephong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblphieuthuephongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblphongBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvthuephong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtNgayden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNgaydi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTraphong;
        private System.Windows.Forms.Button btnTinhtien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTKmaphieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtMaphieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource quanlykhachsandemo2304DataSetBindingSource;
        private quanlykhachsandemo2304DataSet quanlykhachsandemo2304DataSet;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource tblphieuthuephongBindingSource;
        private quanlykhachsandemo2304DataSetTableAdapters.tbl_phieuthuephongTableAdapter tbl_phieuthuephongTableAdapter;
        private System.Windows.Forms.Label lbSongay;
        private System.Windows.Forms.Label lbTongtien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTTHoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPHIEUTHUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANHANVIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHACHHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYDENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYDIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPHONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.BindingSource tblphongBindingSource;
        private quanlykhachsandemo2304DataSetTableAdapters.tbl_phongTableAdapter tbl_phongTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPHONGDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIAPHONGDataGridViewTextBoxColumn;
    }
}