using Winform_QLBN.Models;
using Winform_QLBN.Services;

namespace Winform_QLBN
{
    public partial class FormAdd : Form
    {
        private Data data = new Data();
        public FormAdd()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            Benhnhan benhnhan = new Benhnhan();
            benhnhan.Id = new Guid();
            benhnhan.Name = txtName.Text.Trim();
            benhnhan.Address = txtAddress.Text.Trim();
            benhnhan.Phone = txtPhone.Text.Trim();
            benhnhan.Time = dateTime1.Value;
            benhnhan.Ppdt = txtPpdt.Text.Trim();
            if (benhnhan.Name == "" || benhnhan.Address == "" || benhnhan.Phone == "" || benhnhan.Ppdt == "")
            {
                MessageBox.Show("Vui lòng nhập đủ các thông tin!");
            }
            else
            {
                try
                {
                    Boolean result = await data.InsertdataAsync(benhnhan);
                    if (result)
                    {
                        MessageBox.Show("Lưu thông tin thành công");
                    }
                    else
                    {
                        MessageBox.Show("Lưu thông tin lỗi, vui lòng kiểm tra kết nối!");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Lỗi dữ liệu, Liên hệ Admin!");
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
