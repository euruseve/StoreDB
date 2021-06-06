using System;
using System.Windows.Forms;

namespace CourseDB
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            productIDCB.DataSource = DBUtils.GetAllProducts();
            employeesIDCB.DataSource = DBUtils.GetAllEmployees();
            clientIDCB.DataSource = DBUtils.GetAllClient();
        }

        private void submitProvider_Click(object sender, EventArgs e)
        {
            DBUtils.InsertOrder(productIDCB.SelectedIndex, employeesIDCB.SelectedIndex, clientIDCB.SelectedIndex, datepublishTB.Text, datedoneTB.Text);
            this.Close();
        }
    }
}
