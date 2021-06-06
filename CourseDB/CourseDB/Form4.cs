using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseDB
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            if (DBUtils.mode == 1)
            {
                var x = DBUtils.GetProviderToUpdate(DBUtils.revId);
                companynameTB.Text = x[0];
                providerTB.Text = x[1];
                addressTB.Text = x[2];
                phoneTB.Text = x[3];
            }
        }

        private void submitProvider_Click(object sender, EventArgs e)
        {
            if (DBUtils.mode == 0)
            {
                DBUtils.InsertProvider(companynameTB.Text, providerTB.Text, addressTB.Text, phoneTB.Text);
                this.Close();
            }
            else if (DBUtils.mode == 1)
            {
                DBUtils.UpdateProvider(companynameTB.Text, providerTB.Text, addressTB.Text, phoneTB.Text);
                this.Close();
            }
        }
    }
}
