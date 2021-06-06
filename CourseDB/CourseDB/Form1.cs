using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DBUtils.GetDBConnection("127.0.0.1", "3306", "course_db", "root", "");
            clientLB.DataSource = DBUtils.GetAllClient();
            providerLB.DataSource = DBUtils.GetAllProvider();
            employeesLB.DataSource = DBUtils.GetAllEmployees();
            productLB.DataSource = DBUtils.GetAllProducts();
            orderLB.DataSource = DBUtils.GetAllOrder();
            supplyLB.DataSource = DBUtils.GetAllSupply();
        }

        //Search
        private void productTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var x = DBUtils.GetAllProductsByParticularMatching(DBUtils.MySQLEscape(productTextBox.Text));
            productLB.DataSource = x;
        }

        private void providerTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var x = DBUtils.GetAllProvidersByParticularMatching(DBUtils.MySQLEscape(providerTextBox.Text));
            providerLB.DataSource = x;
        }

        private void supplyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var x = DBUtils.GetAllSupplyByParticularMatching(DBUtils.MySQLEscape(supplyTextBox.Text));
            supplyLB.DataSource = x;
        }

        private void clientTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var x = DBUtils.GetAllClientByParticularMatching(DBUtils.MySQLEscape(clientTextBox.Text));
            clientLB.DataSource = x;
        }

        private void orderTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var x = DBUtils.GetAllOrderByParticularMatching(DBUtils.MySQLEscape(orderTextBox.Text));
            orderLB.DataSource = x;
        }

        private void employeesTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var x = DBUtils.GetAllEmployeesByParticularMatching(DBUtils.MySQLEscape(employeesTextBox.Text));
            employeesLB.DataSource = x;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        //Client
        private void добавитиКлієнтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBUtils.mode = 0;
            var x = new Form2();
            x.ShowDialog();
            clientLB.DataSource = DBUtils.GetAllClient();

        }

        private void видалитиКлієнтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clientLB.SelectedIndex > -1)
            {

                DBUtils.DeleteClient(clientLB.SelectedIndex);
                clientLB.DataSource = DBUtils.GetAllClient();

            }
        }

        private void редагуватиКлієнтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clientLB.SelectedIndex > -1)
            {
                DBUtils.mode = 1;
                DBUtils.revId = clientLB.SelectedIndex;
                var x = new Form2();
                x.ShowDialog();
                clientLB.DataSource = DBUtils.GetAllClient();
            }
        }
        //Emloyees
        private void додатиСпівробітникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBUtils.mode = 0;
            var x = new Form3();
            x.ShowDialog();
            employeesLB.DataSource = DBUtils.GetAllEmployees();

        }
        private void видалитиСпівробітникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (employeesLB.SelectedIndex > -1)
            {
                DBUtils.DeleteEmployees(employeesLB.SelectedIndex);
                employeesLB.DataSource = DBUtils.GetAllEmployees();
            }
        }
        private void редагуватиСпівробітникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (employeesLB.SelectedIndex > -1)
            {
                DBUtils.mode = 1;
                DBUtils.revId = employeesLB.SelectedIndex;
                var x = new Form3();
                x.ShowDialog();
                employeesLB.DataSource = DBUtils.GetAllEmployees();
            }
        }
        //Supply
        private void додатиПоставкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = new Form5();
            x.ShowDialog();
            supplyLB.DataSource = DBUtils.GetAllSupply();
        }
        private void видалитиПоставкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (supplyLB.SelectedIndex > -1)
            {
                DBUtils.DeleteSupply(supplyLB.SelectedIndex);
                supplyLB.DataSource = DBUtils.GetAllSupply();
            }
        }
        //Provider
        private void додатиПостачальникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBUtils.mode = 0;
            var x = new Form4();
            x.ShowDialog();
            providerLB.DataSource = DBUtils.GetAllProvider();
        }

        private void видалитиПостачальникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (providerLB.SelectedIndex > -1)
            {
                DBUtils.DeleteProvider(providerLB.SelectedIndex);
                providerLB.DataSource = DBUtils.GetAllProvider();
            }
        }
        private void редагуватиПостачальникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (providerLB.SelectedIndex > -1)
            {
                DBUtils.mode = 1;
                DBUtils.revId = providerLB.SelectedIndex;
                var x = new Form4();
                x.ShowDialog();
                providerLB.DataSource = DBUtils.GetAllProvider();
            }
        }
        //Order
        private void додатиЗамовленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = new Form6();
            x.ShowDialog();
            orderLB.DataSource = DBUtils.GetAllOrder();
        }

        private void видалитиЗамовленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orderLB.SelectedIndex > -1)
            {
                DBUtils.DeleteOrder(orderLB.SelectedIndex);
                orderLB.DataSource = DBUtils.GetAllOrder();
            }
        }
        //Product
        private void додатиТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = new Form7();
            x.ShowDialog();
            productLB.DataSource = DBUtils.GetAllProducts();
        }

        private void видалитиТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productLB.SelectedIndex > -1)
            {
                DBUtils.DeleteProduct(productLB.SelectedIndex);
                productLB.DataSource = DBUtils.GetAllProducts();
            }
        }
        private void редагуватиТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productLB.SelectedIndex > -1)
            {
                DBUtils.mode = 1;
                DBUtils.revId = productLB.SelectedIndex;
                var x = new Form7();
                x.ShowDialog();
                productLB.DataSource = DBUtils.GetAllProducts();
            }
        }

        private void productLB_DoubleClick(object sender, EventArgs e)
        {
            DBUtils.revId = productLB.SelectedIndex;
            var x = new Form8();
            x.ShowDialog();
        }
    }
}
