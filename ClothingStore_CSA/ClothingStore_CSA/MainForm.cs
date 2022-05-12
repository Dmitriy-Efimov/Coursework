using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingStore_CSA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeTable empTable = new EmployeeTable();
            empTable.ShowDialog();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            ProductTable productTable = new ProductTable();
            productTable.ShowDialog();
        }

        private void DiscountCardButton_Click(object sender, EventArgs e)
        {
            DiscountCardTable discountCardTable = new DiscountCardTable();
            discountCardTable.ShowDialog();
        }

        private void оСотрудникахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeInfoTable employeeInfoTable = new EmployeeInfoTable();
            employeeInfoTable.ShowDialog();
        }

        private void оТоварахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductInfoTable productInfoTable = new ProductInfoTable();
            productInfoTable.ShowDialog();
        }

        private void оРасписанииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleInfoTable scheduleInfoTable = new ScheduleInfoTable();
            scheduleInfoTable.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            ApplicationInfo applicationInfo = new ApplicationInfo();
            applicationInfo.ShowDialog();
        }
    }
}
