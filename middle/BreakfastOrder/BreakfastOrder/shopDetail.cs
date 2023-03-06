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
    public partial class shopDetail : Form
    {
        public shopDetail()
        {
            InitializeComponent();
        }

        private void btnCopyAddress_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(linklblAddress.Text);
        }

        private void btnCopyPhone_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(lblPhone.Text);
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linklblAddress.LinkVisited = false;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://reurl.cc/Wqy7gk");
        }

        private void linklblAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
    }
}
