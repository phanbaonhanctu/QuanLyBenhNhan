using System.Windows.Forms;
using Winform_QLBN.Models;
using Winform_QLBN.Services;

namespace Winform_QLBN
{
    public partial class Form1 : Form
    {
        private Data data = new Data();
        private Guid id = new Guid();
        private List<Benhnhan> benhnhans;
        public Form1()
        {
            InitializeComponent();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            // Gọi phương thức Load ở đây
            benhnhans = await data.LoaddataAsync();
            // Xử lý dữ liệu đã load
            Gview1.DataSource = benhnhans;
            Gview1.Columns[0].HeaderText = "ID";
            Gview1.Columns[0].Visible = false;
            Gview1.Columns[1].HeaderText = "Họ và tên";
            Gview1.Columns[2].HeaderText = "Địa chỉ";
            Gview1.Columns[3].HeaderText = "Số điện thoại";
            Gview1.Columns[4].HeaderText = "Giới tính";
            Gview1.Columns[5].HeaderText = "Thời gian";
            Gview1.Columns[6].HeaderText = "Phương pháp điều trị";
            //Gview1.Columns["Delete"].DisplayIndex = 8;
            //Gview1.Columns["Edit"].DisplayIndex = 8;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của FormAdd
            FormAdd formAdd = new FormAdd();
            formAdd.Owner = this;
            // Hiển thị formAdd
            formAdd.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int indexToRemove = benhnhans.FindIndex(b => b.Id == id);
            if (indexToRemove != -1)
            {
                DialogResult result = MessageBox.Show($"Bạn có muốn xóa Bệnh nhân {benhnhans[indexToRemove].Name}", "Xác nhận xóa", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    benhnhans.RemoveAt(indexToRemove);
                    Gview1.Refresh();
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                }
            }
        }

        private void Gview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Benhnhan? selectedBenhnhan = benhnhans[e.RowIndex];
            if (selectedBenhnhan != null)
            {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                id = selectedBenhnhan.Id;
            }
        }
    }
}