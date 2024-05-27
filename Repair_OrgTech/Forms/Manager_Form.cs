using Microsoft.Office.Interop.Excel;
using QRCoder;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Repair_OrgTech.Forms
{
    public partial class Manager_Form : Form
    {
        public Manager_Form()
        {
            InitializeComponent();
        }

        private void Manager_Form_Load(object sender, EventArgs e)
        {
            Grid_Load();
            GenerateQRCode("https://docs.google.com/forms/d/e/1FAIpQLSdhZcExx6LSIXxk0ub55mSu-WIh23WYdGG9HY5EZhLDo7P8eA/viewform");
        }

        private void Grid_Load()
        {
            try
            {
                grid_Request.DataSource = db_Connect.from_DB("exec sp_FullRequest");

                int count = 0;
                System.Data.DataTable dt_count = db_Connect.from_DB("exec sp_FullRequest");
                for (int i = 0; i < dt_count.Rows.Count; i++)
                {
                    count++;
                }
                lbl_Count.Text = $"Заявок: {count}";

                grid_User.DataSource = db_Connect.from_DB("exec sp_Users");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Обратитесь к системному программисту. Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_Back_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы точно хотите вернуться?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Close();
            }
        }

        private void btn_AddRequest_Click(object sender, EventArgs e)
        {
            AddRequest_Form addRequest_Form = new AddRequest_Form();
            addRequest_Form.ShowDialog();
            Grid_Load();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook;
            Worksheet worksheet;

            workbook = application.Workbooks.Add(System.Reflection.Missing.Value);
            worksheet = (Worksheet)workbook.Worksheets.get_Item(1);

            for (int i = 0; i < grid_Request.Rows.Count; i++)
            {
                for (int j = 0; j < grid_Request.ColumnCount; j++ )
                {
                    application.Cells[i + 1, j + 1] = grid_Request.Rows[i].Cells[j].Value;
                }
            }

            application.Visible = true;
            application.UserControl = true;
        }

        private void GenerateQRCode(string url)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q))
                {
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        Bitmap qrCodeImage = qrCode.GetGraphic(20);
                        box_QR.Image = qrCodeImage;
                    }
                }
            }
        }

        private void btn_AddRoleUser_Click(object sender, EventArgs e)
        {
            AddRoleUser_Form addRoleUser_Form = new AddRoleUser_Form();
            addRoleUser_Form.ShowDialog();
            Grid_Load();
        }
    }
}
