using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
	public partial class QLSinhVienForm : Form
	{
		private DSSinhVien _ds;
		public QLSinhVienForm()
		{
			InitializeComponent();
		}

		private void QLSinhVienForm_Load(object sender, EventArgs e)
		{
			_ds = new DSSinhVien();
			_ds.AddFromFile("data.txt");
			LoadDataToLV(_ds.DanhSach);

		}

		public void LoadDataToLV(List<SinhVien> ds)
		{
			lvDanhSachSV.Items.Clear();
			foreach (var sinhVien in ds)
			{
				var hang = new ListViewItem(sinhVien.MSSV.ToString());
				hang.SubItems.Add(sinhVien.HoVaTenLot);
				hang.SubItems.Add(sinhVien.Ten);
				hang.SubItems.Add(sinhVien.NgaySinh.ToShortDateString());
				hang.SubItems.Add(sinhVien.Phai);
				hang.SubItems.Add(sinhVien.Diem.ToString());

				lvDanhSachSV.Items.Add(hang);
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			var mssv = mtxtMSSV.Text;
			var hoTenLot = txtHoTen.Text;
			var ten = txtTen.Text;
			var ngaySinh = dtpNgaySinh.Value;
			var phai = rdNam.Checked ? "Nam" : "Nữ";
			var diem = Convert.ToDouble(nudDiem.Value);

			var sv = new SinhVien(mssv, hoTenLot, ten, ngaySinh, phai, diem);
			_ds.Add(sv);

			LoadDataToLV(_ds.DanhSach);

		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			var mssv = mtxtMSSV.Text;
			var hoTenLot = txtHoTen.Text;
			var ten = txtTen.Text;
			var ngaySinh = dtpNgaySinh.Value;
			var phai = rdNam.Checked ? "Nam" : "Nữ";
			var diem = Convert.ToDouble(nudDiem.Value);

			if (!_ds.SuaSinhVienTheoMSSV(mssv, hoTenLot, ten, ngaySinh, phai, diem))
				MessageBox.Show("Không tìm thấy sinh viên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

			LoadDataToLV(_ds.DanhSach);
		}

		private void lvDanhSachSV_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvDanhSachSV.SelectedItems.Count > 0)
			{
				var item = lvDanhSachSV.SelectedItems[0];

				mtxtMSSV.Text = item.Text;
				txtHoTen.Text = item.SubItems[1].Text;
				txtTen.Text = item.SubItems[2].Text;
				dtpNgaySinh.Value = Convert.ToDateTime(item.SubItems[3].Text);
				if (item.SubItems[4].Text.CompareTo("Nam")==0)
					rdNam.Checked = true;
				else
				{
					rdNu.Checked = true;
				}

		
				nudDiem.Value = Convert.ToDecimal(item.SubItems[5].Text);

			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			mtxtMSSV.Text = "";
			txtHoTen.Text = "";
			txtTen.Text = "";
			dtpNgaySinh.Value = DateTime.Parse("01/01/2000");
			nudDiem.Value = 5.0M;

		}

		private void btnXemDanhSach_Click(object sender, EventArgs e)
		{
			LoadDataToLV(_ds.DanhSach);
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			var fileName = "Data.txt";
			_ds.LuuDanhSach(fileName);
			MessageBox.Show("Lưu thành công", "Thông báo");
		}

		private void txtTimKiem_TextChanged(object sender, EventArgs e)
		{
			if (rdTen.Checked)
			{
				//var list = _ds.DanhSach.FindAll(sv => sv.Ten.StartsWith(txtTimKiem.Text));
				var list = _ds.TimSVTheoTen(txtTimKiem.Text);
				LoadDataToLV(list);
			}
			else
			{
				var list = _ds.TimSVBatDauMaSo(txtTimKiem.Text);
				LoadDataToLV(list);
			}
		}

		private void rdSVDiemCaoNhat_CheckedChanged(object sender, EventArgs e)
		{
				var list = _ds.TimSVDiemCaoNhat();
				LoadDataToLV(list);
		}

		private void rdSinhVienCoDiemTren_CheckedChanged(object sender, EventArgs e)
		{
			var diem = Convert.ToDouble(nudDiemTim.Value);

			var list = _ds.TimSVDiemLonHon(diem);
			LoadDataToLV(list);
		}

		private void tsmiXoa_Click(object sender, EventArgs e)
		{
			var list = lvDanhSachSV.SelectedItems;

			foreach (ListViewItem item in list)
			{
				_ds.XoaSV(item.Text);
			}
			LoadDataToLV(_ds.DanhSach);
		}

		private void nudDiemTim_ValueChanged(object sender, EventArgs e)
		{
			rdSinhVienCoDiemTren.Enabled = true;
			rdSVCoDiemDuoi.Enabled = true;
		}
	}
}
