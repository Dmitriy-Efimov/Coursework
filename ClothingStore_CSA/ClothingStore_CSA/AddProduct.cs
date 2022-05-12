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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = localhost;"
                 + "Initial Catalog = Сеть магазинов одежды;"
                 + "Trusted_Connection = True;");
            SqlCommand command = connection.CreateCommand();

            try
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddProduct";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = ParametrOne.Text;
                command.Parameters.Add("@Вид_Товара", SqlDbType.NVarChar, 20).Value = ParametrTwo.Text;
                command.Parameters.Add("@Название", SqlDbType.NVarChar, 50).Value = ParametrThree.Text;
                command.Parameters.Add("@Пол", SqlDbType.NVarChar, 15).Value = ParametrFour.Text;
                command.Parameters.Add("@Бренд", SqlDbType.NVarChar, 50).Value = ParametrFive.Text;
                command.Parameters.Add("@Коллекция", SqlDbType.NVarChar, 50).Value = ParametrSix.Text;
                command.Parameters.Add("@Цвет", SqlDbType.NVarChar, 30).Value = ParametrSeven.Text;
                command.Parameters.Add("@Состав", SqlDbType.NVarChar, 50).Value = ParametrEight.Text;
                command.Parameters.Add("@Цена", SqlDbType.Money).Value = ParametrNine.Text;
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
            ProductTable productTable = new ProductTable();
            productTable.Show();
            this.Close();
        }
    }
}
