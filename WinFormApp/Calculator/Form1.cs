using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class CalculatorForm : Form
	{
		public CalculatorForm()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var x = int.Parse(txtX.Text);
			var y = int.Parse(txtY.Text);
			var result = x + y;
			txtResult.Text = result.ToString();
		}

		private void btnSubtract_Click(object sender, EventArgs e)
		{
			var x = int.Parse(txtX.Text);
			var y = int.Parse(txtY.Text);
			var result = x - y;
			txtResult.Text = result.ToString();
		}

		private void cbbLanguage_SelectedIndexChanged(object sender, EventArgs e)
		{
			//txtResult.Text = cbbLanguage.SelectedItem.ToString();
			MessageBox.Show(cbbLanguage.SelectedItem.ToString(),"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
