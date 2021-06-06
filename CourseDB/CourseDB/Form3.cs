using System;
using System.Windows.Forms;

namespace CourseDB
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            if (DBUtils.mode == 1)
            {
                var x = DBUtils.GetEmployeesToUpdate(DBUtils.revId);
                firstnameTB.Text = x[0];
                secondnameTB.Text = x[1];
                positionTB.Text = x[2];
                bdayTB.Text = x[3];
                addressTB.Text = x[4];
                phoneTB.Text = x[5];
            }
        }

        private void submitEmployees_Click(object sender, EventArgs e)
        {
            if (DBUtils.mode == 0)
            {
                DBUtils.InsertEmployees(firstnameTB.Text, secondnameTB.Text, positionTB.Text, bdayTB.Text, addressTB.Text, phoneTB.Text);
                this.Close();
            }
            else if (DBUtils.mode == 1)
            {
                DBUtils.UpdateEmployees(firstnameTB.Text, secondnameTB.Text, positionTB.Text, bdayTB.Text, addressTB.Text, phoneTB.Text);
                this.Close();
            }
        }

    }
}
