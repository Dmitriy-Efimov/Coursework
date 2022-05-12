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
    public partial class ProductTable : Form
    {
        public ProductTable()
        {
            InitializeComponent();
        }

        private void ProductTable_Load(object sender, EventArgs e)
        {
            UpdateTableForm();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
            this.Close();
        }

        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            UpdProduct updProduct = new UpdProduct();
            updProduct.ShowDialog();
            this.Close();
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            DelProduct delProduct = new DelProduct();
            delProduct.ShowDialog();
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
                command.CommandText = "SELECT * FROM Товар";
                command.ExecuteNonQuery();
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet, "Товар");
                ProductGridView.DataSource = dataSet.Tables[0].DefaultView;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
