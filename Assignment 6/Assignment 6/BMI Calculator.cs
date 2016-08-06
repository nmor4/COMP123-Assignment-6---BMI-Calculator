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

        //Changes the app to calculate in Imperial units
        private void ImperialButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ImperialButton.Checked ==true)
            {
                HeightLabel.Text ="My Height(inches)";
                WeightLabel.Text = "My Weight(lbs)"; 

            }
        }

        //changes the app to calculate in Metric units
        private void MetricButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MetricButton.Checked==true)
            {
                HeightLabel.Text = "My Height(metres)";
                WeightLabel.Text = "My Weight(kg)";
            }
        }

        /*Calculates and displays BMI in BMIDisplay and BMIText text boxes. 
         *  Changes formula based on Metric/Imperial radio buttons
         *  Try-catch block handles non-numerical values being entered
         */ 
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            double height = 0;
            
            double weight = 0;
            double  bmi = 0;

            try
            {

                if (MetricButton.Checked==true)
            {
                height = Convert.ToDouble(HeightEntry.Text);
                weight = Convert.ToDouble(WeightEntry.Text);
                bmi= Math.Round((weight / (height * height)), 1);
                BMIDisplay.Text =Convert.ToString( bmi);
                if (bmi<18.5)
                {
                    BMIText.Text = "You are underweight.";
                }
                 else if (bmi>=18.5 &&bmi<25)
                {
                    BMIText.Text = "You are normal weight.";
                }
                else if(bmi>= 25&&bmi<30)
                {
                    BMIText.Text = "You are overweight.";
                    
                }
                else
                {
                    BMIText.Text = "You are obese.";
                }
            }
            else
            {
                height = Convert.ToDouble(HeightEntry.Text);
                weight = Convert.ToDouble(WeightEntry.Text);
                bmi= Math.Round(((weight * 703) / (height * height)), 1);
                    BMIDisplay.Text = Convert.ToString(bmi);
                if (bmi < 18.5)
                {
                    BMIText.Text = "You are underweight.";
                }
                else if (bmi >= 18.5 && bmi < 25)
                {
                    BMIText.Text = "You are normal weight.";
                }
                else if (bmi >= 25 && bmi < 30)
                {
                    BMIText.Text = "You are overweight.";

                }
                else
                {
                    BMIText.Text = "You are obese.";
                }
            }
            }
            catch 
            {
                
                BMIText.Text = "Enter an appropriate numerical value";
                
            }
            
            
        }

        //Clears the text boxes to reset the app
        private void ResetButton_Click(object sender, EventArgs e)
        {
            HeightEntry.Clear();
            WeightEntry.Clear();
            BMIDisplay.Clear();
            BMIText.Clear();
        }

        
    }
}
