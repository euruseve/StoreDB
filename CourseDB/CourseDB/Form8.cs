using System.Drawing;
using System.Windows.Forms;

namespace CourseDB
{
    public partial class Form8 : Form
    {
        string path = null;

        public Form8()
        {
            InitializeComponent();
            var x = DBUtils.GetProductToUpdate(DBUtils.revId);
            nameTB.Text = x[1];
            descroptionTB.Text = x[2];
            pictureBox1.Image = new Bitmap(x[3]);
            path = x[3];
            priceL.Text = x[4];
        }
    }
}
