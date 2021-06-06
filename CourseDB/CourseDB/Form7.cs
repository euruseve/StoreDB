using System;
using System.Drawing;
using System.Windows.Forms;


namespace CourseDB
{
    public partial class Form7 : Form
    {
        string path = null;
        public Form7()
        {
            InitializeComponent();
            supplyIDCB.DataSource = DBUtils.GetAllSupply();
            if (DBUtils.mode == 1)
            {
                var x = DBUtils.GetProductToUpdate(DBUtils.revId);
                nameTB.Text = x[1];
                descriptionTB.Text = x[2];
                pictureBox1.Image = new Bitmap(x[3]);
                path = x[3];
                supllyerpriceTB.Text = x[4];
                aviable.Text = x[5];
                countTB.Text = x[6];
                priceTB.Text = x[7];
            }
        }

        private void img_Click(object sender, EventArgs e)
        {
            var x = new OpenFileDialog();
            x.ShowDialog();
            path = x.FileName;
            pictureBox1.Image = new Bitmap(path);
        }

        private void submitClient_Click(object sender, EventArgs e)
        {
            if (DBUtils.mode == 0)
            {
                if (path != null)
                {
                    double sprice, price;
                    int count;
                    string temp;

                    if (aviable.Checked)
                        temp = "В наявності";
                    else
                    {
                        temp = "Не має в наявності";
                        count = 0;
                    }

                    try
                    {
                        sprice = Convert.ToDouble(supllyerpriceTB.Text);
                        price = Convert.ToDouble(priceTB.Text);
                        count = Convert.ToInt32(countTB.Text);
                    }
                    catch (Exception)
                    {
                        throw new Exception("Uncovert");
                    }

                    DBUtils.InsertProduct(supplyIDCB.SelectedIndex, nameTB.Text, descriptionTB.Text, path, sprice, temp, count, price);
                    this.Close();
                }
            }

            else if (DBUtils.mode == 1)
            {
                if (path != null)
                {
                    double sprice, price;
                    int count;
                    string temp;

                    if (aviable.Checked)
                        temp = "В наявності";
                    else
                    {
                        temp = "Не має в наявності";
                        count = 0;
                    }

                    try
                    {
                        sprice = Convert.ToDouble(supllyerpriceTB.Text);
                        price = Convert.ToDouble(priceTB.Text);
                        count = Convert.ToInt32(countTB.Text);
                    }
                    catch (Exception)
                    {
                        throw new Exception("Uncovert");
                    }

                    DBUtils.UpdateProduct(supplyIDCB.SelectedIndex, nameTB.Text, descriptionTB.Text, path, sprice, temp, count, price);
                    this.Close();
                }
            }
        }
    }
}
