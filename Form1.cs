//Programmer: Eva Zolotarev
//Project: Lab_4
//Date: 3/25/2020
//Description: Using different tax rates, this program calculates the total price.
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        //Declare class-level constants for tax rates and commission rates
        private const decimal STATE_SALES_TAX_RATE = 0.06m;
        private const decimal HILLSBOROUGH_SALES_TAX_RATE = 0.01m;
        private const decimal PASCO_SALES_TAX_RATE = 0m;
        private const decimal POLK_SALES_TAX_RATE = 0.005m;
        private const decimal RESIDENTIAL_COMMISSION_RATE = 0.06m;
        private const decimal COMMERCIAL_COMMISSION_RATE = 0.05m;

        //Declare class-level variables for use in calculation of totals
        //Note: These declarations are being made at the class level not because
        //the variables are used in the multiple methods but, rather, because the method
        //in which they are use (UpdatedTotals) will be called multiple times during
        //a program run and it is unnecessary to declare the same variables repeatedly
        private decimal propertyPrice = 0m;
        private decimal stateSalesTax = 0m;
        private decimal countySalesTax = 0m;
        private decimal commission = 0m;
        private decimal totalPrice = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Display current date (reported by system clock) in sale date control
            salesDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            //Display Save until property price is updated with value greater than zero
            saveButton.Enabled = false;
        }

        private void propertyPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = false; //Disable Save button (until UpdateTotals method runs)
        }

        //Custom method to update total fields
        private void UpdateTotals()
        {
            //Read the price of the property entered by user
            //(TryParse method is used to handle null or non-numeric input)
            if (decimal.TryParse(propertyPriceTextBox.Text, out propertyPrice))
            {
                //Set property price variable equal to text property of text box
                propertyPrice = decimal.Parse(propertyPriceTextBox.Text);

                //Calculate state sales tax amount
                stateSalesTax = propertyPrice * STATE_SALES_TAX_RATE;

                //Calculate county sales tax amount based on county selected
                if (hillRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * HILLSBOROUGH_SALES_TAX_RATE;
                }
                else if (pascoRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * PASCO_SALES_TAX_RATE;
                }

                //Calculate commission based on property type
                if (residentialRadioButton.Checked)
                {
                    commission = propertyPrice * RESIDENTIAL_COMMISSION_RATE;
                }
                else
                {
                    commission = propertyPrice * COMMERCIAL_COMMISSION_RATE;
                }

                //Calculate total price
                totalPrice = propertyPrice + stateSalesTax + countySalesTax + commission;

                //Format and display calculate numeric values with currency formats
                stateSalesTaxLabel.Text = stateSalesTax.ToString("c");
                countySalesTaxLabel.Text = countySalesTax.ToString("c");
                commissionLabel.Text = commission.ToString("c");
                totalPriceLabel.Text = totalPrice.ToString("c");

                if (propertyPrice > 0) //verify that a price greater than zero has been entered
                {
                    saveButton.Enabled = true; //Enable Save button
                }
            }
            else //if null or non-numeric value is entered for property price
            {
                MessageBox.Show("You must enter a numeric value for Property Price." +
                    "\nEnter digits only (no dollar sign) for Property Price.",
                    "Blank Value or Non-Numeric Character Entered",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                propertyPriceTextBox.Focus(); //Send focus to property price text box
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateTotals(); //call custom method to update calculated total
            saveButton.Focus();
        }

        //Handle residental radio button's checked changed event
        //Note: only ONE radio button in this TWO-BUTTON radio button group
        //has to have its CheckedChanged event handled (bacause whenever
        //one button is checked, the other button becomes unchecked; thus, 
        //whenever either button is selected, this event handler runs)
        private void residentialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals(); //Call custom method to update calculated totals
        }

        //Handle Hillsborough radio button's checked changed event
        //Note: only TWO radio buttons in this THREE-BUTTON radio button group
        //have to have their CheckedChanged events handled (bacause whenever
        //one button is checked, the other button becomes unchecked; thus, 
        //whenever either button is selected, this event handler runs)
        private void hillRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals(); //Call custom method to update calculated totals
        }

        //Handle Pasco radio button's checked changed event
        //Note: only two radio buttons in this three-button radio button group
        //have to have their CheckedChanged events handled (because whenever
        //one button is checked, the two other button are unchecked; thus, 
        //all three button can be accounted for with two button event handlers)
        private void pascoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals(); //Call custom method to update calculated totals
        }
        //Handle Save button's click event
        private void saveButton_Click(object sender, EventArgs e)
        {
            try //write date to external text file
            {
                StreamWriter outputFile; //Declare StreamWriter object for use in writing file
                outputFile = File.AppendText("Properties.txt"); //specify file to write to
                //wrtie all data to file
                outputFile.WriteLine("Date: " + salesDateMaskedTextBox.Text);
                outputFile.WriteLine("Property Price: " + propertyPrice.ToString("c"));
                outputFile.WriteLine("State Sales Tax: " + stateSalesTax.ToString("c"));
                outputFile.WriteLine("County Sales Tax: " + countySalesTax.ToString("c"));
                outputFile.WriteLine("Commission: " + commission.ToString("c"));
                outputFile.WriteLine("Total Price: " + totalPrice.ToString("c"));
                outputFile.WriteLine(); // write a blank file to seperate properties
                outputFile.Close(); //close output file after writing data

                MessageBox.Show("Data successfully saved to file.", "Confirmation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information); //display confirmation msg

                ClearForm(); //call custom method to clear form
            }
            catch (Exception ex)
            {
                //Display message if error occurs when attempting to write file
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm(); //Call custom method ot clear form
        }
        //Custom method to clear form
        private void ClearForm()
        {
            //clear control and reset form to original state
            salesDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            residentialRadioButton.Checked = true;
            hillRadioButton.Checked = true;
            propertyPriceTextBox.Text = "0.00";
            stateSalesTaxLabel.Text = "$0.00";
            countySalesTaxLabel.Text = "$0.00";
            commissionLabel.Text = "$0.00";
            totalPriceLabel.Text = "$0.00";
            saveButton.Enabled = false; //diable save button (until UpdateTotals method runs)
            propertyPriceTextBox.Focus(); //send to property price text box
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
