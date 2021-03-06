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
    public partial class ProductInfoTable : Form
    {
        public ProductInfoTable()
        {
            InitializeComponent();
        }

        private void ProductInfoTable_Load(object sender, EventArgs e)
        {
            UpdateTableForm();
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
                command.CommandText = "SELECT * FROM [Информация о Товаре]";
                command.ExecuteNonQuery();
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet, "[Информация о Товаре]");
                ProductInfoGridView.DataSource = dataSet.Tables[0].DefaultView;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
