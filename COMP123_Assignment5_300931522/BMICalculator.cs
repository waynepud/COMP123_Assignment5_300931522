﻿using System;
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
 * Version 1.1: Added variables result, imperial and metric with properties and methods to determine which unit is used
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
        /// This private method determines the output of the BMI calculate
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
                OutputBMITextBox.Text = "Not working";
            }

            //if (this.Metric)
            //{

            //}
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
    }
}
