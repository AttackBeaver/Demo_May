using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repair_OrgTech.Forms
{
    public partial class AddRequest_Form : Form
    {
        public AddRequest_Form()
        {
            InitializeComponent();
        }

        private void AddRequest_Form_Load(object sender, EventArgs e)
        {
            Fill_Box();
        }

        private void Fill_Box()
        {
            try
            {
                DataTable type = db_Connect.from_DB("select*from Tech_Type");
                for (int i = 0; i < type.Rows.Count; i++)
                {
                    if (box_Type.Items.Contains(type.Rows[i][1].ToString()) == false)
                    {
                        box_Type.Items.Add(type.Rows[i][1].ToString());
                    }
                }

                DataTable status = db_Connect.from_DB("select*from Requests_Status");
                for (int i = 0; i < status.Rows.Count; i++)
                {
                    if (box_Status.Items.Contains(status.Rows[i][1].ToString()) == false)
                    {
                        box_Status.Items.Add(status.Rows[i][1].ToString());
                    }
                }

                DataTable master = db_Connect.from_DB("select*from Users where Role_ID = '2'");
                for (int i = 0; i < master.Rows.Count; i++)
                {
                    if (box_Master.Items.Contains(master.Rows[i][2].ToString()) == false)
                    {
                        box_Master.Items.Add(master.Rows[i][2].ToString());
                    }
                }

                DataTable client = db_Connect.from_DB("select*from Users where Role_ID = '1'");
                for (int i = 0; i < client.Rows.Count; i++)
                {
                    if (box_Client.Items.Contains(client.Rows[i][2].ToString()) == false)
                    {
                        box_Client.Items.Add(client.Rows[i][2].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Обратитесь к системному программисту. Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AddRequest_Click(object sender, EventArgs e)
        {
            try
            {
                if (box_Type.Text != " " || box_StartDate.Text != " " || box_Model.Text != " " || box_Problem.Text != " " || box_Status.Text != " "
                    || box_CompDate.Text != " " || box_Parts.Text != " " || box_Master.Text != " " || box_Client.Text != " ")
                {
                    db_Connect.to_DB($"exec sp_AddRequest '{box_Type.SelectedIndex + 1}','{box_StartDate.Text}','{box_Model.Text}','{box_Problem.Text}'," +
                        $"'{box_Status.SelectedIndex + 1}','{box_CompDate.Text}','{box_Parts.Text}','{box_Master.SelectedIndex + 1}','{box_Client.SelectedIndex + 1}'");
                    MessageBox.Show("Заявка успешно добавлена", "Заявка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Заполните данные", "Заявка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Обратитесь к системному программисту. Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
