using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Wayne Pud
 * Student ID: 300931522
 * Date: August 3, 2017
 * Description: This is a form that calculates a person's BMI (Body Mass Index)
 * Version 1.0: Created the BMICalculator form
 */

namespace COMP123_Assignment5_300931522
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculator());
        }
    }
}
