using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NinasCookieSource
{
    public partial class NinaCookieSource : Form
    {
        string type;
        double price;
        double totalPrice;
        public NinaCookieSource()
        {
            InitializeComponent();
        }

        private void rbtnSamoas_CheckedChanged(object sender, EventArgs e)
        {
            dTPOrderDate.MinDate = DateTime.Today;
            if(rbtnSamoas.Checked)
            {
                lblType.Text = rbtnSamoas.Text;
                price = 1;
                if (rbtnOnehalf.Checked)
                {
                    totalPrice = 6*price;
                    lblCookiesPrice.Text = rbtnOnehalf.Text + " dozen of " + lblType.Text + " is : $" + totalPrice;
                }
                else if (rbtnOne.Checked)
                {
                    totalPrice = 12 * price;
                    lblCookiesPrice.Text = rbtnOne.Text + " dozen of " + lblType.Text + " is : $" + totalPrice;
                }
                else if (rbtnTwo.Checked)
                {
                    totalPrice = 24 * price;
                    lblCookiesPrice.Text = rbtnTwo.Text + " dozen of " + lblType.Text + " is : $" + totalPrice;
                }
                else
                {
                    totalPrice = 36 * price;
                    lblCookiesPrice.Text = rbtnThree.Text + " dozen of " + lblType.Text + " is : $" + totalPrice;
                }
                lblOnePrice.Text = "The cost of one " + lblType.Text + " is : $" + price;
                lblDeliveryDate.Text = "Your order will arrived on : " + (dTPOrderDate.Value.AddDays(3)).ToLongDateString();
            }
            else if (rbtnTagalongs.Checked)
            {
                lblType.Text = rbtnTagalongs.Text;
                price = 2;
                if (rbtnOnehalf.Checked)
                {
                    totalPrice = 6 * price;
                    lblCookiesPrice.Text = rbtnOnehalf.Text+ " dozen of " + lblType.Text + " is : $" + totalPrice;
                }                          
                else if (rbtnOne.Checked)  
                {                          
                    totalPrice = 12 * price;
                    lblCookiesPrice.Text = rbtnOne.Text + " dozen of " + lblType.Text + " is : $" + totalPrice;
                }                          
                else if (rbtnTwo.Checked)  
                {                          
                    totalPrice = 24 * price;
                    lblCookiesPrice.Text = rbtnTwo.Text + " dozen of " + lblType.Text + " is : $" + totalPrice;
                }                          
                else                       
                {                          
                    totalPrice = 36 * price;
                    lblCookiesPrice.Text = rbtnThree.Text+ " dozen of " + lblType.Text + " is : $" + totalPrice;
                }
                lblOnePrice.Text = "The cost of one " + lblType.Text + " is : $" + price;
                lblDeliveryDate.Text = "Your order will arrived on : " + (dTPOrderDate.Value.AddDays(3)).ToLongDateString();
            }
            else
            {
                lblType.Text = rbtnTrefoils.Text;
                price = 3;
                if (rbtnOnehalf.Checked)
                {
                    totalPrice = 6 * price;
                    lblCookiesPrice.Text = rbtnOnehalf.Text + " dozen of " + lblType.Text + " is : $" + totalPrice;
                }
                else if (rbtnOne.Checked)
                {
                    totalPrice = 12 * price;
                    lblCookiesPrice.Text = rbtnOne.Text + " dozen of " + lblType.Text + " is : $" + totalPrice;
                }
                else if (rbtnTwo.Checked)
                {
                    totalPrice = 24 * price;
                    lblCookiesPrice.Text = rbtnTwo.Text + " dozen of " + lblType.Text + " is : $" + totalPrice;
                }
                else
                {
                    totalPrice = 36 * price;
                    lblCookiesPrice.Text = rbtnThree.Text + " dozen of " + lblType.Text + " is : $" + totalPrice;
                }
                lblOnePrice.Text = "The cost of one " + lblType.Text + " is : $" + price;
                lblDeliveryDate.Text = "Your order will arrived on : " + (dTPOrderDate.Value.AddDays(3)).ToLongDateString();
            }
        }

        private void dTPOrderDate_ValueChanged(object sender, EventArgs e)
        {
            lblDeliveryDate.Text = "Your order will arrived on : " + (dTPOrderDate.Value.AddDays(3)).ToLongDateString();
        }
    }
}
