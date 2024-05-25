using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repair_OrgTech
{
    public class db_Connect
    {
        public static string con = "Data Source = localhost; Initial Catalog = Repair_OrgTech; Integrated Security = true";

        public static SqlConnection sqlConnection()
        {
            return new SqlConnection(con);
        }

        public static DataTable from_DB(string sql)
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection());
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                DataTable dataTable = new DataTable();
                dataTable = dataSet.Tables[0];
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Обратитесь к системному программисту. Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static void to_DB(string sql)
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection());
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Обратитесь к системному программисту. Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
