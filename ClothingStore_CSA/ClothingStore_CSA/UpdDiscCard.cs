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
    public partial class UpdDiscCard : Form
    {
        public UpdDiscCard()
        {
            InitializeComponent();
        }

        private void UpdateDiscCardButtonn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = localhost;"
                 + "Initial Catalog = Сеть магазинов одежды;"
                 + "Trusted_Connection = True;");
            SqlCommand command = connection.CreateCommand();

            try
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "UpdateDiscountCard";
                command.Parameters.Add("@Номер", SqlDbType.BigInt).Value = ParametrOne.Text;
                command.Parameters.Add("@ФИО", SqlDbType.NVarChar, 50).Value = ParametrTwo.Text;
                command.Parameters.Add("@Скидка", SqlDbType.NVarChar, 3).Value = ParametrThree.Text;
                command.Parameters.Add("@Сумма", SqlDbType.Money).Value = ParametrFour.Text;
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
            DiscountCardTable discountCardTable = new DiscountCardTable();
            discountCardTable.Show();
            this.Close();
        }
    }
}
