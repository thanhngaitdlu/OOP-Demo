namespace Calculator
{
	partial class CalculatorForm
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
			this.txtX = new System.Windows.Forms.TextBox();
			this.txtY = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnSubtract = new System.Windows.Forms.Button();
			this.btnMultiply = new System.Windows.Forms.Button();
			this.btnDivide = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.cbbLanguage = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "X:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Y:";
			// 
			// txtX
			// 
			this.txtX.Location = new System.Drawing.Point(62, 10);
			this.txtX.Name = "txtX";
			this.txtX.Size = new System.Drawing.Size(210, 20);
			this.txtX.TabIndex = 0;
			// 
			// txtY
			// 
			this.txtY.Location = new System.Drawing.Point(62, 41);
			this.txtY.Name = "txtY";
			this.txtY.Size = new System.Drawing.Size(210, 20);
			this.txtY.TabIndex = 1;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(19, 108);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(41, 26);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnSubtract
			// 
			this.btnSubtract.Location = new System.Drawing.Point(87, 108);
			this.btnSubtract.Name = "btnSubtract";
			this.btnSubtract.Size = new System.Drawing.Size(41, 26);
			this.btnSubtract.TabIndex = 3;
			this.btnSubtract.Text = "-";
			this.btnSubtract.UseVisualStyleBackColor = true;
			this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
			// 
			// btnMultiply
			// 
			this.btnMultiply.Location = new System.Drawing.Point(155, 108);
			this.btnMultiply.Name = "btnMultiply";
			this.btnMultiply.Size = new System.Drawing.Size(41, 26);
			this.btnMultiply.TabIndex = 4;
			this.btnMultiply.Text = "*";
			this.btnMultiply.UseVisualStyleBackColor = true;
			// 
			// btnDivide
			// 
			this.btnDivide.Location = new System.Drawing.Point(221, 108);
			this.btnDivide.Name = "btnDivide";
			this.btnDivide.Size = new System.Drawing.Size(41, 26);
			this.btnDivide.TabIndex = 5;
			this.btnDivide.Text = "/";
			this.btnDivide.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Kết quả";
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(62, 73);
			this.txtResult.Name = "txtResult";
			this.txtResult.ReadOnly = true;
			this.txtResult.Size = new System.Drawing.Size(210, 20);
			this.txtResult.TabIndex = 6;
			// 
			// cbbLanguage
			// 
			this.cbbLanguage.FormattingEnabled = true;
			this.cbbLanguage.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Đức",
            "Tiếng Nga"});
			this.cbbLanguage.Location = new System.Drawing.Point(114, 145);
			this.cbbLanguage.Name = "cbbLanguage";
			this.cbbLanguage.Size = new System.Drawing.Size(121, 21);
			this.cbbLanguage.TabIndex = 7;
			this.cbbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbbLanguage_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Chọn ngoại ngữ";
			// 
			// CalculatorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 256);
			this.Controls.Add(this.cbbLanguage);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnDivide);
			this.Controls.Add(this.btnMultiply);
			this.Controls.Add(this.btnSubtract);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtY);
			this.Controls.Add(this.txtX);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "CalculatorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtX;
		private System.Windows.Forms.TextBox txtY;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnSubtract;
		private System.Windows.Forms.Button btnMultiply;
		private System.Windows.Forms.Button btnDivide;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.ComboBox cbbLanguage;
		private System.Windows.Forms.Label label4;
	}
}

