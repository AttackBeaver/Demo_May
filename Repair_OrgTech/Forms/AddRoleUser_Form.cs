using System;
using System.Data;
using System.Windows.Forms;

namespace Repair_OrgTech.Forms
{
    public partial class AddRoleUser_Form : Form
    {
        public AddRoleUser_Form()
        {
            InitializeComponent();
        }

        private void AddRoleUser_Form_Load(object sender, EventArgs e)
        {
            Fill_Box();
        }

        private void Fill_Box()
        {
            try
            {
                DataTable type = db_Connect.from_DB("select*from Roles");
                for (int i = 0; i < type.Rows.Count; i++)
                {
                    if (box_RoleSelect.Items.Contains(type.Rows[i][1].ToString()) == false)
                    {
                        box_RoleSelect.Items.Add(type.Rows[i][1].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Обратитесь к системному программисту. Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AddRole_Click(object sender, EventArgs e)
        {
            try
            {
                if (box_Role.Text != " ")
                {
                    db_Connect.to_DB($"exec sp_AddRoles '{box_Role.Text}'");
                    MessageBox.Show("Роль успешно добавлена", "Роль", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Fill_Box();
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

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            try
            {
                db_Connect.to_DB($"exec sp_AddUsers '{box_RoleSelect.SelectedIndex+1}','{box_Surname.Text}','{box_Name.Text}'," +
                    $"'{box_Lastname.Text}','{box_Phone.Text}','{box_Login.Text}','{box_Password.Text}'");
                MessageBox.Show("Пользователь успешно добавлен", "Пользователь", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
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
    }
}
