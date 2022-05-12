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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = localhost;"
                  + "Initial Catalog = Сеть магазинов одежды;"
                  + "Trusted_Connection = True;");
            SqlCommand command = connection.CreateCommand();

            try
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddEmployee";
                command.Parameters.Add("@ФИО", SqlDbType.NVarChar, 50).Value = ParametrOne.Text;
                command.Parameters.Add("@Пол", SqlDbType.NVarChar, 15).Value = ParametrTwo.Text;
                command.Parameters.Add("@Возраст", SqlDbType.Int).Value = ParametrThree.Text;
                command.Parameters.Add("@Должность", SqlDbType.NVarChar, 20).Value = ParametrFour.Text;
                command.Parameters.Add("@Стаж", SqlDbType.Int).Value = ParametrFive.Text;
                command.Parameters.Add("@ИНН", SqlDbType.BigInt).Value = ParametrSix.Text;
                command.Parameters.Add("@Телефон", SqlDbType.BigInt).Value = ParametrSeven.Text;
                command.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = ParametrEight.Text;
                command.Parameters.Add("@Дата_Рождения", SqlDbType.DateTime2).Value = ParametrNine.Value;
                command.Parameters.Add("@Дата_Найма", SqlDbType.DateTime2).Value = ParametrTen.Value;
                connection.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            EmployeeTable employeeTable = new EmployeeTable();
            employeeTable.Show();
            this.Close();
        }
    }
}
