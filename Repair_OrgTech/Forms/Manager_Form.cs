using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                for (int j = 0; j < grid_Request.ColumnCount; i++ )
                {
                    application.Cells[i + 1, j + 1] = grid_Request.Rows[i].Cells[j].Value;
                }
            }

            application.Visible = true;
            application.UserControl = true;
        }
    }
}
