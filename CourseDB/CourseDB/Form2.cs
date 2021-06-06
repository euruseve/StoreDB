using System;
using System.Windows.Forms;

namespace CourseDB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if(DBUtils.mode == 1)
            {
                var x = DBUtils.GetClientToUpdate(DBUtils.revId);
                fullnameTB.Text = x[0];
                addressTB.Text = x[1];
                phoneTB.Text = x[2];
            }
        }

        private void submitClient_Click(object sender, EventArgs e)
        {
            if (DBUtils.mode == 0)
            {
                DBUtils.InsertClients(fullnameTB.Text, addressTB.Text, phoneTB.Text);
                this.Close();
            }
            else if(DBUtils.mode == 1)
            {
                DBUtils.UpdateClient(fullnameTB.Text, addressTB.Text, phoneTB.Text);
                this.Close();
            }
        }
    }
}
