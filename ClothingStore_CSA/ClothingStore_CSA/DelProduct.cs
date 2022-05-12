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
    public partial class DelProduct : Form
    {
        public DelProduct()
        {
            InitializeComponent();
        }

        private void DeleteProductButtonn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = localhost;"
                  + "Initial Catalog = Сеть магазинов одежды;"
                  + "Trusted_Connection = True;");
            SqlCommand command = connection.CreateCommand();

            try
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DeleteProduct";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = ParametrOne.Text;
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
