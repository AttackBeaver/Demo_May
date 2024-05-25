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
    public partial class Operator_Form : Form
    {
        public Operator_Form()
        {
            InitializeComponent();
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
