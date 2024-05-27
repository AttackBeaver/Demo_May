using QRCoder;
using Repair_OrgTech.Forms;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Repair_OrgTech
{
    public partial class Autorization_Form : Form
    {
        public Autorization_Form()
        {
            InitializeComponent();
        }

        public void check_Password_CheckedChanged(object sender, EventArgs e)
        {
            box_Password.UseSystemPasswordChar = !box_Password.UseSystemPasswordChar;
        }

        public void btn_SignIn_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = false;

                Debug.WriteLine("Начало проверки логина и пароля.");
                DataTable dataTable = db_Connect.from_DB("select*from Users");
                Debug.WriteLine("Запрос к базе данных выполнен.");

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string login = dataTable.Rows[i][6].ToString();
                    string password = dataTable.Rows[i][7].ToString();

                    Debug.WriteLine($"Проверка пользователя: {login}");

                    if (box_Login.Text == login && box_Password.Text == password)
                    {
                        int role = Convert.ToInt32(dataTable.Rows[i][1]);
                        Debug.WriteLine($"Успешная авторизация для пользователя: {login}, пароль: {password}");

                        switch (role)
                        {
                            case 1:
                                MessageBox.Show("Успешно", "Вход в систему", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Client_Form client_Form = new Client_Form();
                                client_Form.ShowDialog();
                                result = true;
                                break;
                            case 2:
                                MessageBox.Show("Успешно", "Вход в систему", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Master_Form master_Form = new Master_Form();
                                master_Form.ShowDialog();
                                result = true;
                                break;
                            case 3:
                                MessageBox.Show("Успешно", "Вход в систему", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Manager_Form manager_Form = new Manager_Form();
                                manager_Form.ShowDialog();
                                result = true;
                                break;
                            case 4:
                                MessageBox.Show("Успешно", "Вход в систему", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Operator_Form operator_Form = new Operator_Form();
                                operator_Form.ShowDialog();
                                result = true;
                                break;
                            default:
                                Debug.WriteLine($"Неизвестная роль: {role} для пользователя: {login}");
                                result = false;
                                break;
                        }
                        if (result == false)
                        {
                            MessageBox.Show($"Неверные данные для входа", "Вход в систему", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Обратитесь к системному программисту. Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void lbl_LogIn_Click(object sender, EventArgs e)
        {
            AddRequest_Form addRequest_Form = new AddRequest_Form();
            addRequest_Form.ShowDialog();
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

        private void Autorization_Form_Load(object sender, EventArgs e)
        {
            GenerateQRCode("https://docs.google.com/forms/d/e/1FAIpQLSdhZcExx6LSIXxk0ub55mSu-WIh23WYdGG9HY5EZhLDo7P8eA/viewform");
        }
    }
}
