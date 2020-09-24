//Name: Isaac Ingles
//Class: INFO 1200
//Section: X01
//Professor: Jensen
//Date: 9/24/2020
//Project #: Participation 7
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IILoanQualifier
{
    public partial class MainPage : ContentPage
    {
        // Declare years and salary as constants to make them more dynamic
        const int MIN_YEARS = 3;
        const decimal MIN_SALARY = 40000.00m;
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  Validate user input, test input using if/else conditional statements
        ///  to determine whether input was valid or whether the person qualifies 
        ///  for a loan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnQualify_Clicked(object sender, EventArgs e)
        {
            // Test whether years is a number
            if (int.TryParse(YearsEntry.Text, out int years))
            {
                
                // Test whether salary input is a decimal
                if (decimal.TryParse(SalaryEntry.Text, out decimal salary))
                {
                    // Find out if we qualify (years greater to or equal than 3)
                    if (years >= MIN_YEARS)
                    {
                        // Test whether salary is greater to or equal than 40k
                        if (salary >= MIN_SALARY)
                        {
                            // Display an alert if we've made it past all of the conditional statements
                            DisplayAlert("You Qualify", "You have qualified for the loan!", "Close");
                        }
                        else
                        {
                            // Display an alert if the salary is less than $40,000
                            DisplayAlert("Not Qualified", "You must have a salary more than $40,000", "Close");
                        }
                    }
                    
                    else
                    {   
                        // Display an alert if the person hasn't had a job for at least 3 years
                        DisplayAlert("Not Qualified", "You must have a job for at least 3 years to qualify!", "Close");
                    }
                }
                else
                {
                    // Display an alert if the salary wasn't a number
                    DisplayAlert("Invalid Input", "Please enter a number for the salary!", "Close");
                }
            }
            else
            {
                // Display an alert if the salary wasn't an integer
                DisplayAlert("Invalid Input", "Please enter an integer for the years!", "Close");
            }
        }
    }
}
