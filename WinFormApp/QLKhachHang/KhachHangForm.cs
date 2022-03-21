using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachHang
{
	public partial class KhachHangForm : Form
	{
		private DSKhachHang _ds;
		public KhachHangForm()
		{
			InitializeComponent();
		}

		private void KhachHangForm_Load(object sender, EventArgs e)
		{
			_ds = new DSKhachHang();
			_ds.DocDanhSachTuTapTin("data.txt");
			LoadDaTaToLV(_ds.DanhSach);
		}

		private void LoadDaTaToLV(List<KhachHang> list )
		{
			lvDanhSach.Items.Clear();
			foreach (var khachHang in list)
			{
				var hang = new ListViewItem(khachHang.TenKhachHang);
				hang.SubItems.Add(khachHang.SoDT);
				hang.SubItems.Add(khachHang.Diem.ToString());

				lvDanhSach.Items.Add(hang);
			}
		}

		private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvDanhSach.SelectedItems.Count > 0)
			{
				var item = lvDanhSach.SelectedItems[0];

				txtTenKH.Text = item.Text;
				mtxtSDT.Text = item.SubItems[1].Text;
				nudDiem.Text = item.SubItems[2].Text;

			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			var sdt = mtxtSDT.Text.Replace(".", "");
			var diem = Convert.ToInt32(nudDiem.Value);

			_ds.SuaDiem(sdt, diem);
			LoadDaTaToLV(_ds.DanhSach);
		}
	}
}
