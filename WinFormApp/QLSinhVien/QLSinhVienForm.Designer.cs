namespace QLSinhVien
{
	partial class QLSinhVienForm
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
			this.mtxtMSSV = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.rdNam = new System.Windows.Forms.RadioButton();
			this.rdNu = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.nudDiem = new System.Windows.Forms.NumericUpDown();
			this.lvDanhSachSV = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ctmListView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiXoa = new System.Windows.Forms.ToolStripMenuItem();
			this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdSVCoDiemDuoi = new System.Windows.Forms.RadioButton();
			this.rdSinhVienCoDiemTren = new System.Windows.Forms.RadioButton();
			this.nudDiemTim = new System.Windows.Forms.NumericUpDown();
			this.rdSinhVienDiemThapNhat = new System.Windows.Forms.RadioButton();
			this.rdSVDiemCaoNhat = new System.Windows.Forms.RadioButton();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.rdTen = new System.Windows.Forms.RadioButton();
			this.rdMSSV = new System.Windows.Forms.RadioButton();
			this.btnXemDanhSach = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudDiem)).BeginInit();
			this.ctmListView.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDiemTim)).BeginInit();
			this.SuspendLayout();
			// 
			// mtxtMSSV
			// 
			this.mtxtMSSV.Location = new System.Drawing.Point(114, 21);
			this.mtxtMSSV.Mask = "0000000";
			this.mtxtMSSV.Name = "mtxtMSSV";
			this.mtxtMSSV.Size = new System.Drawing.Size(186, 20);
			this.mtxtMSSV.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "MSSV";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Họ và Tên lót";
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(114, 47);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(186, 20);
			this.txtHoTen.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tên";
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(114, 73);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(186, 20);
			this.txtTen.TabIndex = 2;
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgaySinh.Location = new System.Drawing.Point(113, 99);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(186, 20);
			this.dtpNgaySinh.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Ngày sinh";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 135);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(28, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Phái";
			// 
			// rdNam
			// 
			this.rdNam.AutoSize = true;
			this.rdNam.Location = new System.Drawing.Point(113, 130);
			this.rdNam.Name = "rdNam";
			this.rdNam.Size = new System.Drawing.Size(47, 17);
			this.rdNam.TabIndex = 4;
			this.rdNam.TabStop = true;
			this.rdNam.Text = "Nam";
			this.rdNam.UseVisualStyleBackColor = true;
			// 
			// rdNu
			// 
			this.rdNu.AutoSize = true;
			this.rdNu.Location = new System.Drawing.Point(201, 130);
			this.rdNu.Name = "rdNu";
			this.rdNu.Size = new System.Drawing.Size(39, 17);
			this.rdNu.TabIndex = 5;
			this.rdNu.TabStop = true;
			this.rdNu.Text = "Nữ";
			this.rdNu.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 164);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Điểm";
			// 
			// nudDiem
			// 
			this.nudDiem.DecimalPlaces = 1;
			this.nudDiem.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.nudDiem.Location = new System.Drawing.Point(113, 164);
			this.nudDiem.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudDiem.Name = "nudDiem";
			this.nudDiem.Size = new System.Drawing.Size(120, 20);
			this.nudDiem.TabIndex = 6;
			// 
			// lvDanhSachSV
			// 
			this.lvDanhSachSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.lvDanhSachSV.ContextMenuStrip = this.ctmListView;
			this.lvDanhSachSV.FullRowSelect = true;
			this.lvDanhSachSV.GridLines = true;
			this.lvDanhSachSV.Location = new System.Drawing.Point(12, 237);
			this.lvDanhSachSV.Name = "lvDanhSachSV";
			this.lvDanhSachSV.Size = new System.Drawing.Size(592, 316);
			this.lvDanhSachSV.TabIndex = 7;
			this.lvDanhSachSV.UseCompatibleStateImageBehavior = false;
			this.lvDanhSachSV.View = System.Windows.Forms.View.Details;
			this.lvDanhSachSV.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachSV_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "MSSV";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Họ và tên lót";
			this.columnHeader2.Width = 130;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Ngày sinh";
			this.columnHeader4.Width = 68;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Phái";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Điểm";
			// 
			// ctmListView
			// 
			this.ctmListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiXoa,
            this.sửaToolStripMenuItem});
			this.ctmListView.Name = "ctmListView";
			this.ctmListView.Size = new System.Drawing.Size(95, 48);
			// 
			// tsmiXoa
			// 
			this.tsmiXoa.Name = "tsmiXoa";
			this.tsmiXoa.Size = new System.Drawing.Size(94, 22);
			this.tsmiXoa.Text = "Xóa";
			this.tsmiXoa.Click += new System.EventHandler(this.tsmiXoa_Click);
			// 
			// sửaToolStripMenuItem
			// 
			this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
			this.sửaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
			this.sửaToolStripMenuItem.Text = "Sửa";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 209);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Danh sách sinh viên";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtHoTen);
			this.groupBox1.Controls.Add(this.mtxtMSSV);
			this.groupBox1.Controls.Add(this.nudDiem);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.rdNu);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.rdNam);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.dtpNgaySinh);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtTen);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(287, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(316, 196);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin chi tiết";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rdSVCoDiemDuoi);
			this.groupBox2.Controls.Add(this.rdSinhVienCoDiemTren);
			this.groupBox2.Controls.Add(this.nudDiemTim);
			this.groupBox2.Controls.Add(this.rdSinhVienDiemThapNhat);
			this.groupBox2.Controls.Add(this.rdSVDiemCaoNhat);
			this.groupBox2.Controls.Add(this.txtTimKiem);
			this.groupBox2.Controls.Add(this.rdTen);
			this.groupBox2.Controls.Add(this.rdMSSV);
			this.groupBox2.Location = new System.Drawing.Point(12, 19);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(260, 184);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tìm kiếm";
			// 
			// rdSVCoDiemDuoi
			// 
			this.rdSVCoDiemDuoi.AutoSize = true;
			this.rdSVCoDiemDuoi.Location = new System.Drawing.Point(13, 151);
			this.rdSVCoDiemDuoi.Name = "rdSVCoDiemDuoi";
			this.rdSVCoDiemDuoi.Size = new System.Drawing.Size(136, 17);
			this.rdSVCoDiemDuoi.TabIndex = 6;
			this.rdSVCoDiemDuoi.TabStop = true;
			this.rdSVCoDiemDuoi.Text = "Sinh viên có điểm dưới:";
			this.rdSVCoDiemDuoi.UseVisualStyleBackColor = true;
			// 
			// rdSinhVienCoDiemTren
			// 
			this.rdSinhVienCoDiemTren.AutoSize = true;
			this.rdSinhVienCoDiemTren.Location = new System.Drawing.Point(13, 122);
			this.rdSinhVienCoDiemTren.Name = "rdSinhVienCoDiemTren";
			this.rdSinhVienCoDiemTren.Size = new System.Drawing.Size(137, 17);
			this.rdSinhVienCoDiemTren.TabIndex = 5;
			this.rdSinhVienCoDiemTren.TabStop = true;
			this.rdSinhVienCoDiemTren.Text = "Sinh viên có điểm trên :";
			this.rdSinhVienCoDiemTren.UseVisualStyleBackColor = true;
			this.rdSinhVienCoDiemTren.CheckedChanged += new System.EventHandler(this.rdSinhVienCoDiemTren_CheckedChanged);
			// 
			// nudDiemTim
			// 
			this.nudDiemTim.DecimalPlaces = 1;
			this.nudDiemTim.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.nudDiemTim.Location = new System.Drawing.Point(155, 135);
			this.nudDiemTim.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudDiemTim.Name = "nudDiemTim";
			this.nudDiemTim.Size = new System.Drawing.Size(91, 20);
			this.nudDiemTim.TabIndex = 7;
			this.nudDiemTim.Value = new decimal(new int[] {
            50,
            0,
            0,
            65536});
			// 
			// rdSinhVienDiemThapNhat
			// 
			this.rdSinhVienDiemThapNhat.AutoSize = true;
			this.rdSinhVienDiemThapNhat.Location = new System.Drawing.Point(13, 93);
			this.rdSinhVienDiemThapNhat.Name = "rdSinhVienDiemThapNhat";
			this.rdSinhVienDiemThapNhat.Size = new System.Drawing.Size(158, 17);
			this.rdSinhVienDiemThapNhat.TabIndex = 4;
			this.rdSinhVienDiemThapNhat.TabStop = true;
			this.rdSinhVienDiemThapNhat.Text = "Sinh viên có điểm thấp nhất";
			this.rdSinhVienDiemThapNhat.UseVisualStyleBackColor = true;
			// 
			// rdSVDiemCaoNhat
			// 
			this.rdSVDiemCaoNhat.AutoSize = true;
			this.rdSVDiemCaoNhat.Location = new System.Drawing.Point(13, 63);
			this.rdSVDiemCaoNhat.Name = "rdSVDiemCaoNhat";
			this.rdSVDiemCaoNhat.Size = new System.Drawing.Size(155, 17);
			this.rdSVDiemCaoNhat.TabIndex = 3;
			this.rdSVDiemCaoNhat.TabStop = true;
			this.rdSVDiemCaoNhat.Text = "Sinh viên có điểm cao nhất";
			this.rdSVDiemCaoNhat.UseVisualStyleBackColor = true;
			this.rdSVDiemCaoNhat.CheckedChanged += new System.EventHandler(this.rdSVDiemCaoNhat_CheckedChanged);
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(124, 26);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(122, 20);
			this.txtTimKiem.TabIndex = 2;
			this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
			// 
			// rdTen
			// 
			this.rdTen.AutoSize = true;
			this.rdTen.Location = new System.Drawing.Point(74, 27);
			this.rdTen.Name = "rdTen";
			this.rdTen.Size = new System.Drawing.Size(44, 17);
			this.rdTen.TabIndex = 1;
			this.rdTen.TabStop = true;
			this.rdTen.Text = "Tên";
			this.rdTen.UseVisualStyleBackColor = true;
			// 
			// rdMSSV
			// 
			this.rdMSSV.AutoSize = true;
			this.rdMSSV.Location = new System.Drawing.Point(13, 27);
			this.rdMSSV.Name = "rdMSSV";
			this.rdMSSV.Size = new System.Drawing.Size(55, 17);
			this.rdMSSV.TabIndex = 0;
			this.rdMSSV.TabStop = true;
			this.rdMSSV.Text = "MSSV";
			this.rdMSSV.UseVisualStyleBackColor = true;
			// 
			// btnXemDanhSach
			// 
			this.btnXemDanhSach.Location = new System.Drawing.Point(145, 208);
			this.btnXemDanhSach.Name = "btnXemDanhSach";
			this.btnXemDanhSach.Size = new System.Drawing.Size(75, 23);
			this.btnXemDanhSach.TabIndex = 1;
			this.btnXemDanhSach.Text = "Tải lại ds";
			this.btnXemDanhSach.UseVisualStyleBackColor = true;
			this.btnXemDanhSach.Click += new System.EventHandler(this.btnXemDanhSach_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(364, 208);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 5;
			this.btnReset.Text = "Xóa form";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(445, 209);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 3;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(528, 210);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 4;
			this.btnSua.Text = "Cập nhật";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(226, 208);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(75, 23);
			this.btnLuu.TabIndex = 6;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// QLSinhVienForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(616, 565);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnXemDanhSach);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lvDanhSachSV);
			this.Controls.Add(this.label7);
			this.Name = "QLSinhVienForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phần mềm quản lý điểm sinh viên";
			this.Load += new System.EventHandler(this.QLSinhVienForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudDiem)).EndInit();
			this.ctmListView.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDiemTim)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox mtxtMSSV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.DateTimePicker dtpNgaySinh;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton rdNam;
		private System.Windows.Forms.RadioButton rdNu;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown nudDiem;
		private System.Windows.Forms.ListView lvDanhSachSV;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rdSVCoDiemDuoi;
		private System.Windows.Forms.RadioButton rdSinhVienCoDiemTren;
		private System.Windows.Forms.NumericUpDown nudDiemTim;
		private System.Windows.Forms.RadioButton rdSinhVienDiemThapNhat;
		private System.Windows.Forms.RadioButton rdSVDiemCaoNhat;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.RadioButton rdTen;
		private System.Windows.Forms.RadioButton rdMSSV;
		private System.Windows.Forms.Button btnXemDanhSach;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.ContextMenuStrip ctmListView;
		private System.Windows.Forms.ToolStripMenuItem tsmiXoa;
		private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
	}
}

