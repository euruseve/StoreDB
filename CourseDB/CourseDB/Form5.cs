using System;
using System.Windows.Forms;

namespace CourseDB
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            idCB.DataSource = DBUtils.GetAllProvider();
        }

        private void submitProvider_Click(object sender, EventArgs e)
        {
            DBUtils.InsertSupply(idCB.SelectedIndex, dateTB.Text);
            this.Close();
        }
    }
}
