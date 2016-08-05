using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();

                
            

        }

        private void ImperialButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ImperialButton.Checked ==true)
            {
                HeightLabel.Text ="My Height(inches)";
                WeightLabel.Text = "My Weight(lbs)"; 

            }
        }

        private void MetricButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MetricButton.Checked==true)
            {
                HeightLabel.Text = "My Height(metres)";
                WeightLabel.Text = "My Weight(kg)";
            }
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {

        }
    }
}
