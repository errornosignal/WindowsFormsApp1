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
            Double.TryParse(this.LengthTextBox.Text, out double length);

            //var width = Convert.ToDouble(this.WidthTextBox.Text);
            Double.TryParse(this.WidthTextBox.Text, out double width);

            var area = length * width;

            this.ResultsTextBox.Text = $"The Area is : {area:F2}";

        }
    }
}
