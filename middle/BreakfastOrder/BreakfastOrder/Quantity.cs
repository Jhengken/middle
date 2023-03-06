using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakfastOrder
{
    public partial class Quantity : Form
    {
        public ListViewItem idx = new ListViewItem();
        public int intQuantuty = 1;
        public int intPrice = 1;
        public int totlePrice = 1;
        public Quantity()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxProduct.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProduct.Image = idx.ImageList.Images[idx.Index];  //滑鼠select到的Lisview裡面的ImageList
            lblProductName.Text = idx.Name;
            lblQuantity.Text = intQuantuty.ToString();
            //intPrice = intPrice * intQuantuty;   //擷取idx.text
            totlePrice = intPrice * intQuantuty;
            lblPrice.Text = totlePrice.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            intQuantuty++;
            lblQuantity.Text = intQuantuty.ToString();
            //intPrice = intPrice * intQuantuty;
            totlePrice = intPrice * intQuantuty;
            lblPrice.Text = totlePrice.ToString();
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            if (intQuantuty > 0) { intQuantuty--; }
                else { intQuantuty=0; }
            lblQuantity.Text = intQuantuty.ToString();
            //intPrice = intPrice * intQuantuty;
            totlePrice = intPrice * intQuantuty;
            lblPrice.Text = totlePrice.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
