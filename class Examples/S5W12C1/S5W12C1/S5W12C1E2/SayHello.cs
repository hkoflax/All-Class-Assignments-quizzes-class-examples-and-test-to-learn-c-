using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S5W12C1E2
{
    public partial class SayHello : Form
    {
        public SayHello()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            lblDisplayName.Text = "";
            string name = txtbSayHello.Text;
            bool checkFeeling = chbFeelingGood.Checked;
            if (name!="")
            {
                if (checkFeeling)
                {
                    lblDisplayName.Text += "Hello"+name+",\nhappy to know that you are good";
                }
                else
                {
                    lblDisplayName.Text += "Hello" + name +",\nsorry to hear that.  ";
                }
            }
            else
            {
                lblDisplayName.Text = "You have not input any name";
            }
        }
    }
}
