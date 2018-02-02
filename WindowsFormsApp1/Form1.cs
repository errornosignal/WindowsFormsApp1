using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // var length = Convert.ToDouble(this.LengthTextBox.Text);
            double.TryParse(this.LengthTextBox.Text, out double length);

            //var width = Convert.ToDouble(this.WidthTextBox.Text);
            double.TryParse(this.WidthTextBox.Text, out double width);

            var area = length * width;

            this.ResultsTextBox.Text = $"{area:F2}";
        }

        private void CalculateShippingChargesButton_Click(object sender, EventArgs e)
        {
            var StandardShippingRate = 1.0m;
            var ExpeditedShippingCost = 2.0m;
            var InternationalShippingCost = 3.0m;

            var optionCost = 0.0m;
            if (this.StandardShippingRadioButton.Checked)
            {
                optionCost = StandardShippingRate;
            }
            else if (this.ExpeditedShippingRadioButton.Checked)
            {
                optionCost = ExpeditedShippingCost;
            }
            else
            { 
                optionCost = InternationalShippingCost;  
            }

            if (decimal.TryParse(this.ShippingWeightTextBox.Text, out decimal weight))
            {
                if (weight < 0.0m)
                {
                    MessageBox.Show("Invalid Weight Entered!" +
                                    "\nMust be greater than zero.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.ShippingWeightTextBox.Clear();
                    this.ShippingWeightTextBox.Focus();
                }
                else
                {
                    var total = optionCost + (0.1m * weight);
                    this.ShippingChargesTextBox.Text = $"{total:C}";
                }
            }
            else
            {
                MessageBox.Show("Invalid Data Entered!" +
                                "\nNon-Numeric Input.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.ShippingWeightTextBox.Clear();
                this.ShippingWeightTextBox.Focus();
            }
        }

        private void ResetFormButton_Click(object sender, EventArgs e)
        {
            this.ShippingWeightTextBox.Clear();
            this.ShippingWeightTextBox.Focus();
            this.ShippingChargesTextBox.Clear();
            this.ResultsTextBox.Text = string.Empty;
            this.StandardShippingRadioButton.Checked = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
