using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingStore_CSA
{
    public partial class EmployeeTable : Form
    {
        public EmployeeTable()
        {
            InitializeComponent();
        }

        private void EmployeeTable_Load(object sender, EventArgs e)
        {
            UpdateTableForm();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
            this.Close();
        }

        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            UpdEmployee updEmployee = new UpdEmployee();
            updEmployee.ShowDialog();
            this.Close();
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            DelEmployee delEmployee = new DelEmployee();
            delEmployee.ShowDialog();
            this.Close();
        }

        private void UpdateTableForm()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = localhost;"
                  + "Initial Catalog = Сеть магазинов одежды;"
                  + "Trusted_Connection = True;");
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            SqlCommand command = connection.CreateCommand();
            DataSet dataSet = new DataSet();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Работник";
                command.ExecuteNonQuery();
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet, "Работник");
                EmployeeGridView.DataSource = dataSet.Tables[0].DefaultView;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
