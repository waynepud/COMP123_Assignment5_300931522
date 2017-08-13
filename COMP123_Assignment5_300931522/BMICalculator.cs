using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Wayne Pud
 * Student ID: 300931522
 * Date: August 13, 2017
 * Description: This is a form that calculates a person's BMI (Body Mass Index)
 * Version 1.4: Added Numerical input keypress restriction methods
 */
 
namespace COMP123_Assignment5_300931522
{
    public partial class BMICalculator : Form
    {
        // PRIVATE INSTANCE VARIABLES
        private double _result;
        private bool _imperial;
        private bool _metric;


        // PUBLIC PROPERTIES
        public double Result
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value;
            }
        }

        public bool Imperial
        {
            get
            {
                return this._imperial;
            }
            set
            {
                this._imperial = value;
            }
        }

        public bool Metric
        {
            get
            {
                return this._metric;
            }
            set
            {
                this._metric = value;
            }
        }



        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor of the BMICalculator Form
        /// </summary>
        public BMICalculator()
        {
            InitializeComponent();
        }

        // PRIVATE METHODS
        /// <summary>
        /// This private method determines the output in which units (calculation switches) of the BMI calculate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            if (InchOrMeterBMILabel.Text == "Inches")
            {
                Result = (Convert.ToDouble(WeightBMITextBox.Text) * 703) / (Convert.ToDouble(HeightBMITextBox.Text) * Convert.ToDouble(HeightBMITextBox.Text));
                OutputBMITextBox.Text = Convert.ToString(Result);
            }
            else
            {
                Result = (Convert.ToDouble(WeightBMITextBox.Text)) / (Convert.ToDouble(HeightBMITextBox.Text) * Convert.ToDouble(HeightBMITextBox.Text));
                OutputBMITextBox.Text = Convert.ToString(Result);
            }

            if (Result < 18.5)
            {
                ScaleBMITextBox.Text = "Your BMI is considered underweight.";
            }
            if (Result >= 18.5 && Result <= 24.9)
            {
                ScaleBMITextBox.Text = "Your BMI is considered normal.";
            }
            if (Result >= 25 && Result <= 29.9)
            {
                ScaleBMITextBox.Text = "Your BMI is considered overweight.";
            }
            if (Result >= 30)
            {
                ScaleBMITextBox.Text = "Your BMI is considered obese.";
            }
        }


        /// <summary>
        /// These private methods determine which unit is used when the button is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialBMIButton_CheckedChanged(object sender, EventArgs e)
        {
            InchOrMeterBMILabel.Text = "Inches";
            PoundOrKGBMILabel.Text = "Pounds";
        }

        private void MetricBMIButton_CheckedChanged(object sender, EventArgs e)
        {
            InchOrMeterBMILabel.Text = "Meters";
            PoundOrKGBMILabel.Text = "Kilograms";
        }


        /// <summary>
        /// This method resets the form back to default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetBMIButton_Click(object sender, EventArgs e)
        {
            HeightBMITextBox.Text = "0";
            WeightBMITextBox.Text = "0";
            OutputBMITextBox.Text = "";
            ScaleBMITextBox.Text = "";
        }


        /// <summary>
        /// These two keypress methods restrict input to only be numerical values with 1 decimal point allowed
        /// Note: This code was referenced from https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
        /// to understand the approach towards how to restrict inputs as in keypress to numerical values only
        /// The idea behind it is to match the conditions of the key being only digit and decimal and not other inputs then the event (e) becomes true
        /// which allows the input to be processed
        /// The second if condition represents if the char is a decimal and the text within the textbox counts no decimal char already (noted by >-1) 
        /// then the event (e) is considered true and the decimal is shown, otherwise the decimal will not show
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightBMITextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void WeightBMITextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
