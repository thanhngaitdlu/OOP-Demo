using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMonAn
{
	public partial class MainForm : Form
	{
		private DSMonAn _dsMonAn;
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var ten = txtTenMonAn.Text;
			var nhom = cbbNhomMonAn.SelectedItem.ToString();
			var dvt = txtDonViTinh.Text;
			var dongia = Convert.ToInt32(nudDonGia.Value);

			if (string.IsNullOrWhiteSpace(ten)|| string.IsNullOrWhiteSpace(nhom) || string.IsNullOrWhiteSpace(dvt))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var monAn = new MonAn(ten, nhom, dvt, dongia);
			_dsMonAn.Add(monAn);
			LoadDataToLv(_dsMonAn.DsMonAn);

		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			_dsMonAn = new DSMonAn();

			_dsMonAn.AddFromFile();

			LoadDataToLv(_dsMonAn.DsMonAn);
		}

		private void LoadDataToLv(List<MonAn> list)
		{
			lvDsMonAn.Items.Clear();

			foreach (var monAn in list)
			{
				var item = new ListViewItem(monAn.TenMonAn);
				item.SubItems.Add(monAn.NhomMonAn);
				item.SubItems.Add(monAn.DonViTinh);
				item.SubItems.Add(monAn.DonGia.ToString());

				lvDsMonAn.Items.Add(item);
			}
			
		}

		private void lvDsMonAn_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvDsMonAn.SelectedItems.Count > 0)
			{
				var item = lvDsMonAn.SelectedItems[0];
			
				txtTenMonAn.Text = item.Text;
				cbbNhomMonAn.Text = item.SubItems[1].Text;
				txtDonViTinh.Text = item.SubItems[2].Text;
				nudDonGia.Text = item.SubItems[3].Text;
			}
			
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var ten = txtTenMonAn.Text;

			if (_dsMonAn.XoaMonAn(ten))
				LoadDataToLv(_dsMonAn.DsMonAn);
			else
			{
				MessageBox.Show("Không tìm thấy món ăn này", "Thông báo");
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var ten = txtTenMonAn.Text;
			var nhom = cbbNhomMonAn.SelectedItem.ToString();
			var dvt = txtDonViTinh.Text;
			var donGia = Convert.ToInt32(nudDonGia.Value);

			var kq = _dsMonAn.SuaMonAnTheoTen(ten, dvt, nhom, donGia);
			if (kq == false)
				MessageBox.Show("Không tồn tại món ăn này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			LoadDataToLv(_dsMonAn.DsMonAn);
		}

		private void rdTimMonAnDGCaoNhat_CheckedChanged(object sender, EventArgs e)
		{
			var ds = _dsMonAn.TimMonAnCoDGCaoNhat();

			LoadDataToLv(ds);
		}

		private void rdTimMonAnDGThapNhat_CheckedChanged(object sender, EventArgs e)
		{
			var ds = _dsMonAn.TimMonAnCoDGThapNhat();

			LoadDataToLv(ds);
		}

		private void btnReLoad_Click(object sender, EventArgs e)
		{
			LoadDataToLv(_dsMonAn.DsMonAn);
		}

		private void cbbTimTheoNhom_SelectedIndexChanged(object sender, EventArgs e)
		{
			var tenNhom = cbbTimTheoNhom.SelectedItem.ToString();

			var ds = _dsMonAn.TimTheoNhom(tenNhom);
			LoadDataToLv(ds);
		}
	}
}
