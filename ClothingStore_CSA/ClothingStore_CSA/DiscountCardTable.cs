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
    public partial class DiscountCardTable : Form
    {
        public DiscountCardTable()
        {
            InitializeComponent();
        }

        private void DiscountCardTable_Load(object sender, EventArgs e)
        {
            UpdateTableForm();
        }

        private void AddDicsCardButton_Click(object sender, EventArgs e)
        {
            AddDiscCard addDiscCard = new AddDiscCard();
            addDiscCard.ShowDialog();
            this.Close();
        }

        private void UpdateDiscCardButton_Click(object sender, EventArgs e)
        {
            UpdDiscCard updDiscCard = new UpdDiscCard();
            updDiscCard.ShowDialog();
            this.Close();
        }

        private void DeleteDicsCardButton_Click(object sender, EventArgs e)
        {
            DelDiscCard delDiscCard = new DelDiscCard();
            delDiscCard.ShowDialog();
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
                command.CommandText = "SELECT * FROM [Скидочная Карта]";
                command.ExecuteNonQuery();
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet, "[Скидочная Карта]");
                DiscCardGridView.DataSource = dataSet.Tables[0].DefaultView;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
