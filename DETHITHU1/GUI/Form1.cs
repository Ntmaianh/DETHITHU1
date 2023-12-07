using DETHITHU1.BUS;
using DETHITHU1.DomainClass;

namespace DETHITHU1
{
    public partial class Form1 : Form
    {
        Service service = new Service();
        Guid _idWhenClick = new Guid();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadData(int? status)
        {
            int Stt = 1;
            dgvXeMay.ColumnCount = 6;
            dgvXeMay.Rows.Clear();
            dgvXeMay.Columns[0].Name = "id";
            dgvXeMay.Columns[1].Name = "STT";
            dgvXeMay.Columns[2].Name = "Tên";
            dgvXeMay.Columns[3].Name = "Mã";
            dgvXeMay.Columns[4].Name = "Gía bán";
            dgvXeMay.Columns[5].Name = "Trạng thái";
            dgvXeMay.Columns[0].Visible = false;
            foreach (var item in service.GetAllService(status))
            {
                dgvXeMay.Rows.Add(item.Id, Stt++, item.Ten, item.Ma, item.GiaBan, item.TrangThai);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadData(null);
        }

        private void dgvXeMay_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _idWhenClick = Guid.Parse(dgvXeMay.Rows[e.RowIndex].Cells[0].Value.ToString());
            var result = service.GetAllService(null).First(x => x.Id == _idWhenClick);
            txtMa.Text = result.Ma;
            txtTen.Text = result.Ten;
            txtGia.Text = result.GiaBan.ToString();
            if (result.TrangThai == 1)
            {
                radbtnConHang.Checked = true;
                radbtnHetHang.Checked = false;
            }
            else
            {
                radbtnConHang.Checked = false;
                radbtnHetHang.Checked = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtGia.Text = "";
            radbtnConHang.Checked = false;
            radbtnHetHang.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = service.GetAllService(null).Any(x => x.Ma == txtMa.Text);
                if (check)
                {
                    MessageBox.Show("Mã đã tồn tại");
                    return;
                }
                else
                {
                    XeMay xemay = new XeMay();
                    xemay.Ma = txtMa.Text;
                    xemay.Ten = txtTen.Text;
                    xemay.GiaBan = Convert.ToDecimal(txtGia.Text);
                    if (radbtnConHang.Checked)
                    {
                        xemay.TrangThai = 1;
                    }
                    else
                    {
                        xemay.TrangThai = 0;
                    }
                    service.AddXeMayService(xemay);
                    LoadData(null);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thoông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                service.DeleteXeMayService(_idWhenClick);
                LoadData(null);
            }
        }

        private void cbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoc_SelectedIndexChanged != null)
            {
                if(cbLoc.SelectedIndex == 0)
                {
                    LoadData(1);
                }
                else if(cbLoc.SelectedIndex == 1)
                {
                    LoadData(0);
                }
                else
                {
                    LoadData(null);
                }
            }
        }
    }
}