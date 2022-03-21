namespace QLKhachHang
{
	partial class KhachHangForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtTenKH = new System.Windows.Forms.TextBox();
			this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.nudDiem = new System.Windows.Forms.NumericUpDown();
			this.lvDanhSach = new System.Windows.Forms.ListView();
			this.label4 = new System.Windows.Forms.Label();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTimSĐT = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.nudDiem)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên khách hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Số điện thoại";
			// 
			// txtTenKH
			// 
			this.txtTenKH.Location = new System.Drawing.Point(135, 18);
			this.txtTenKH.Name = "txtTenKH";
			this.txtTenKH.Size = new System.Drawing.Size(126, 20);
			this.txtTenKH.TabIndex = 1;
			// 
			// mtxtSDT
			// 
			this.mtxtSDT.Location = new System.Drawing.Point(135, 54);
			this.mtxtSDT.Mask = "0000.000.000";
			this.mtxtSDT.Name = "mtxtSDT";
			this.mtxtSDT.Size = new System.Drawing.Size(126, 20);
			this.mtxtSDT.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Điểm tích lũy";
			// 
			// nudDiem
			// 
			this.nudDiem.Location = new System.Drawing.Point(135, 88);
			this.nudDiem.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.nudDiem.Name = "nudDiem";
			this.nudDiem.Size = new System.Drawing.Size(120, 20);
			this.nudDiem.TabIndex = 4;
			// 
			// lvDanhSach
			// 
			this.lvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lvDanhSach.FullRowSelect = true;
			this.lvDanhSach.GridLines = true;
			this.lvDanhSach.Location = new System.Drawing.Point(6, 205);
			this.lvDanhSach.Name = "lvDanhSach";
			this.lvDanhSach.Size = new System.Drawing.Size(279, 121);
			this.lvDanhSach.TabIndex = 5;
			this.lvDanhSach.UseCompatibleStateImageBehavior = false;
			this.lvDanhSach.View = System.Windows.Forms.View.Details;
			this.lvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lvDanhSach_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 189);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(119, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Danh sách khách hàng";
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Tên khách hàng";
			this.columnHeader1.Width = 120;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Số điện thoại";
			this.columnHeader2.Width = 91;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Điểm";
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(129, 157);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 6;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(210, 157);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 6;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(26, 123);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Tìm theo SĐT";
			// 
			// txtTimSĐT
			// 
			this.txtTimSĐT.Location = new System.Drawing.Point(135, 120);
			this.txtTimSĐT.Name = "txtTimSĐT";
			this.txtTimSĐT.Size = new System.Drawing.Size(126, 20);
			this.txtTimSĐT.TabIndex = 1;
			// 
			// KhachHangForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 331);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.lvDanhSach);
			this.Controls.Add(this.nudDiem);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.mtxtSDT);
			this.Controls.Add(this.txtTimSĐT);
			this.Controls.Add(this.txtTenKH);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "KhachHangForm";
			this.Text = "Tích điểm khách hàng";
			this.Load += new System.EventHandler(this.KhachHangForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudDiem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTenKH;
		private System.Windows.Forms.MaskedTextBox mtxtSDT;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nudDiem;
		private System.Windows.Forms.ListView lvDanhSach;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTimSĐT;
	}
}

