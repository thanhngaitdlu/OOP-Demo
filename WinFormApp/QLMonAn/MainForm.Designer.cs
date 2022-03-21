namespace QLMonAn
{
	partial class MainForm
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
			this.txtTenMonAn = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblMessage = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDonViTinh = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lvDsMonAn = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label5 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.nudDonGia = new System.Windows.Forms.NumericUpDown();
			this.rdTimMonAnDGCaoNhat = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdTimMonAnDGThapNhat = new System.Windows.Forms.RadioButton();
			this.btnReLoad = new System.Windows.Forms.Button();
			this.cbbNhomMonAn = new System.Windows.Forms.ComboBox();
			this.cbbTimTheoNhom = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.ForestGreen;
			this.label1.Location = new System.Drawing.Point(44, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên món ăn:";
			// 
			// txtTenMonAn
			// 
			this.txtTenMonAn.Location = new System.Drawing.Point(152, 35);
			this.txtTenMonAn.Name = "txtTenMonAn";
			this.txtTenMonAn.Size = new System.Drawing.Size(220, 20);
			this.txtTenMonAn.TabIndex = 0;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(121, 123);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Location = new System.Drawing.Point(57, 221);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(10, 13);
			this.lblMessage.TabIndex = 3;
			this.lblMessage.Text = ".";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.ForestGreen;
			this.label2.Location = new System.Drawing.Point(44, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nhóm món ăn:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.ForestGreen;
			this.label3.Location = new System.Drawing.Point(44, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Đơn vị tính:";
			// 
			// txtDonViTinh
			// 
			this.txtDonViTinh.Location = new System.Drawing.Point(152, 63);
			this.txtDonViTinh.Name = "txtDonViTinh";
			this.txtDonViTinh.Size = new System.Drawing.Size(220, 20);
			this.txtDonViTinh.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.ForestGreen;
			this.label4.Location = new System.Drawing.Point(44, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Đơn giá:";
			// 
			// lvDsMonAn
			// 
			this.lvDsMonAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvDsMonAn.FullRowSelect = true;
			this.lvDsMonAn.GridLines = true;
			this.lvDsMonAn.Location = new System.Drawing.Point(12, 172);
			this.lvDsMonAn.Name = "lvDsMonAn";
			this.lvDsMonAn.Size = new System.Drawing.Size(589, 249);
			this.lvDsMonAn.TabIndex = 4;
			this.lvDsMonAn.UseCompatibleStateImageBehavior = false;
			this.lvDsMonAn.View = System.Windows.Forms.View.Details;
			this.lvDsMonAn.SelectedIndexChanged += new System.EventHandler(this.lvDsMonAn_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Tên món ăn";
			this.columnHeader1.Width = 250;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Nhóm món ăn";
			this.columnHeader2.Width = 134;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Đơn vị tính";
			this.columnHeader3.Width = 111;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Đơn giá";
			this.columnHeader4.Width = 81;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.ForestGreen;
			this.label5.Location = new System.Drawing.Point(12, 149);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(113, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Danh sách món ăn";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(230, 123);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "Sửa";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(334, 123);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// nudDonGia
			// 
			this.nudDonGia.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nudDonGia.Location = new System.Drawing.Point(152, 89);
			this.nudDonGia.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nudDonGia.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nudDonGia.Name = "nudDonGia";
			this.nudDonGia.Size = new System.Drawing.Size(120, 20);
			this.nudDonGia.TabIndex = 5;
			this.nudDonGia.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			// 
			// rdTimMonAnDGCaoNhat
			// 
			this.rdTimMonAnDGCaoNhat.AutoSize = true;
			this.rdTimMonAnDGCaoNhat.Location = new System.Drawing.Point(30, 19);
			this.rdTimMonAnDGCaoNhat.Name = "rdTimMonAnDGCaoNhat";
			this.rdTimMonAnDGCaoNhat.Size = new System.Drawing.Size(179, 17);
			this.rdTimMonAnDGCaoNhat.TabIndex = 6;
			this.rdTimMonAnDGCaoNhat.TabStop = true;
			this.rdTimMonAnDGCaoNhat.Text = "Tìm món ăn có đơn giá cao nhất";
			this.rdTimMonAnDGCaoNhat.UseVisualStyleBackColor = true;
			this.rdTimMonAnDGCaoNhat.CheckedChanged += new System.EventHandler(this.rdTimMonAnDGCaoNhat_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbbTimTheoNhom);
			this.groupBox1.Controls.Add(this.rdTimMonAnDGThapNhat);
			this.groupBox1.Controls.Add(this.rdTimMonAnDGCaoNhat);
			this.groupBox1.Location = new System.Drawing.Point(399, 19);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(222, 98);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm kiếm";
			// 
			// rdTimMonAnDGThapNhat
			// 
			this.rdTimMonAnDGThapNhat.AutoSize = true;
			this.rdTimMonAnDGThapNhat.Location = new System.Drawing.Point(30, 45);
			this.rdTimMonAnDGThapNhat.Name = "rdTimMonAnDGThapNhat";
			this.rdTimMonAnDGThapNhat.Size = new System.Drawing.Size(182, 17);
			this.rdTimMonAnDGThapNhat.TabIndex = 6;
			this.rdTimMonAnDGThapNhat.TabStop = true;
			this.rdTimMonAnDGThapNhat.Text = "Tìm món ăn có đơn giá thấp nhất";
			this.rdTimMonAnDGThapNhat.UseVisualStyleBackColor = true;
			this.rdTimMonAnDGThapNhat.CheckedChanged += new System.EventHandler(this.rdTimMonAnDGThapNhat_CheckedChanged);
			// 
			// btnReLoad
			// 
			this.btnReLoad.Location = new System.Drawing.Point(441, 123);
			this.btnReLoad.Name = "btnReLoad";
			this.btnReLoad.Size = new System.Drawing.Size(104, 23);
			this.btnReLoad.TabIndex = 2;
			this.btnReLoad.Text = "Tải lại danh sách";
			this.btnReLoad.UseVisualStyleBackColor = true;
			this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
			// 
			// cbbNhomMonAn
			// 
			this.cbbNhomMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbNhomMonAn.FormattingEnabled = true;
			this.cbbNhomMonAn.Items.AddRange(new object[] {
            "Hải sản",
            "Lẩu",
            "Cơm",
            "Gà",
            "Khai vị",
            "Nướng",
            "Rau"});
			this.cbbNhomMonAn.Location = new System.Drawing.Point(152, 8);
			this.cbbNhomMonAn.Name = "cbbNhomMonAn";
			this.cbbNhomMonAn.Size = new System.Drawing.Size(220, 21);
			this.cbbNhomMonAn.TabIndex = 8;
			// 
			// cbbTimTheoNhom
			// 
			this.cbbTimTheoNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbTimTheoNhom.FormattingEnabled = true;
			this.cbbTimTheoNhom.Items.AddRange(new object[] {
            "Hải sản",
            "Lẩu",
            "Cơm",
            "Gà",
            "Khai vị",
            "Nướng",
            "Rau"});
			this.cbbTimTheoNhom.Location = new System.Drawing.Point(30, 71);
			this.cbbTimTheoNhom.Name = "cbbTimTheoNhom";
			this.cbbTimTheoNhom.Size = new System.Drawing.Size(179, 21);
			this.cbbTimTheoNhom.TabIndex = 8;
			this.cbbTimTheoNhom.SelectedIndexChanged += new System.EventHandler(this.cbbTimTheoNhom_SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(624, 444);
			this.Controls.Add(this.cbbNhomMonAn);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.nudDonGia);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lvDsMonAn);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.btnReLoad);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDonViTinh);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtTenMonAn);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý các món ăn - Nhà hàng ABC";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTenMonAn;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDonViTinh;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListView lvDsMonAn;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.NumericUpDown nudDonGia;
		private System.Windows.Forms.RadioButton rdTimMonAnDGCaoNhat;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdTimMonAnDGThapNhat;
		private System.Windows.Forms.Button btnReLoad;
		private System.Windows.Forms.ComboBox cbbNhomMonAn;
		private System.Windows.Forms.ComboBox cbbTimTheoNhom;
	}
}

