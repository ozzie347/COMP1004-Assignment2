/**
App: COMP1004-Assignment2
Author: Nicholas Oshukany
Last Modified: 02/14/2017
Description: This program calculates the amount due on a new or used vehicle
*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAssignment2
{
    public partial class AutoCenterForm : Form
    {
        //Variables
        private double _basePrice;
        private double _additionalOptions;
        private double _subTotal;
        private double _salesTax;
        private double _total;
        private double _tradeInAllowance;
        private double _amountDue;
        private double _stereoPrice = 100;
        private double _leatherPrice = 500;
        private double _gpsPrice = 50;
        private double _pearlizedPrice = 125;
        private double _customDetailedPrice = 999;

        ///Initialization
        public AutoCenterForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Add and remove the stereo option from the vehicle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stereoSystemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(stereoSystemCheckBox.Checked == true)
            {
                additionalOptionsTextBox.Text = (_additionalOptions += _stereoPrice).ToString();
            }
            if(stereoSystemCheckBox.Checked == false)
            {
                additionalOptionsTextBox.Text = (_additionalOptions -= _stereoPrice).ToString();
            }
        }

        /// <summary>
        /// Add and remove the leather interior option from the vehicle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leatherInteriorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(leatherInteriorCheckBox.Checked == true)
            {
                additionalOptionsTextBox.Text = (_additionalOptions += _leatherPrice).ToString();
            }
            if (leatherInteriorCheckBox.Checked == false)
            {
                additionalOptionsTextBox.Text = (_additionalOptions -= _leatherPrice).ToString();
            }
        }

        /// <summary>
        /// Add or remove the computer navigation option from the vehicle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void computerNavigationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(computerNavigationCheckBox.Checked == true)
            {
                additionalOptionsTextBox.Text = (_additionalOptions += _gpsPrice).ToString();
            }
            if (computerNavigationCheckBox.Checked == false)
            {
                additionalOptionsTextBox.Text = (_additionalOptions -= _gpsPrice).ToString();
            }
        }

        /// <summary>
        /// Set the exterior finish to pearlized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pearlizedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(pearlizedRadioButton.Checked == true)
            {
                additionalOptionsTextBox.Text = (_additionalOptions += _pearlizedPrice).ToString();
            }
            if (pearlizedRadioButton.Checked == false)
            {
                additionalOptionsTextBox.Text = (_additionalOptions -= _pearlizedPrice).ToString();
            }
        }

        /// <summary>
        /// Set the exterior finish to custom detailed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customizedDetailingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(customizedDetailingRadioButton.Checked == true)
            {
                additionalOptionsTextBox.Text = (_additionalOptions += _customDetailedPrice).ToString();
            }
            if (customizedDetailingRadioButton.Checked == false)
            {
                additionalOptionsTextBox.Text = (_additionalOptions -= _customDetailedPrice).ToString();
            }
        }

        /// <summary>
        /// Calculation formula for the subtotal, tax, total, and amount owed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (basePriceTextBox.Text == "")
            {
                MessageBox.Show("Please enter a base price");
            }
            else if (tradeInAllowanceTextBox.Text == "")
            {
                MessageBox.Show("Please enter a value for trade-in allowance");
            }
            else
            {
                _subTotal = (_basePrice + _additionalOptions);
                subTotalTextBox.Text = _subTotal.ToString("C2");
                _salesTax = (_subTotal * 0.13);
                salesTaxTextBox.Text = _salesTax.ToString("C2");
                _total = (_subTotal + _salesTax);
                totalTextBox.Text = _total.ToString("C2");
                _amountDue = (_total - _tradeInAllowance);
                amountDueTextBox.Text = _amountDue.ToString("C2");
            }
        }

        /// <summary>
        /// Clear the fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            basePriceTextBox.Text = "";
            additionalOptionsTextBox.Text = "";
            subTotalTextBox.Text = "";
            salesTaxTextBox.Text = "";
            totalTextBox.Text = "";
            tradeInAllowanceTextBox.Text = "0";
            amountDueTextBox.Text = "";
            stereoSystemCheckBox.Checked = false;
            leatherInteriorCheckBox.Checked = false;
            computerNavigationCheckBox.Checked = false;
            standardRadioButton.Checked = true;
            pearlizedRadioButton.Checked = false;
            customizedDetailingRadioButton.Checked = false;
        }

        //Exit the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //About popup
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program calculates the amount due on a new or used vehicle", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //ensures a value is set for the base price
        private void basePriceTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (basePriceTextBox.Text == "")
                {
                    MessageBox.Show("Please enter a value");
                }
                else
                {
                    _basePrice = Convert.ToDouble(basePriceTextBox.Text);
                }
                basePriceTextBox.Text = _basePrice.ToString("C2");
            }
            //if value is not a number
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("An error occurred", ex);
            }
            
        }

        //ensures a value is set for the trade in allowance
        private void tradeInAllowanceTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (tradeInAllowanceTextBox.Text == "")
                {
                    MessageBox.Show("Please enter a value");
                }
                else
                {
                    _tradeInAllowance = Convert.ToDouble(tradeInAllowanceTextBox.Text);
                }
                tradeInAllowanceTextBox.Text = _tradeInAllowance.ToString("C2");
            }
            //if value is not a number
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("An error occurred", ex);
            }
        }

        //Change the fonts
        private void microsoftSansSerifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            basePriceTextBox.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            amountDueTextBox.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            basePriceTextBox.Font = new Font("Times New Roman", 8, FontStyle.Regular);
            amountDueTextBox.Font = new Font("Times New Roman", 8, FontStyle.Regular);
        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            basePriceTextBox.Font = new Font("Comic Sans", 8, FontStyle.Regular);
            amountDueTextBox.Font = new Font("Comic Sans", 8, FontStyle.Regular);
        }

        //change the colors of the base and amount
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            basePriceTextBox.BackColor = Color.White;
            amountDueTextBox.BackColor = Color.White;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            basePriceTextBox.BackColor = Color.Green;
            amountDueTextBox.BackColor = Color.Green;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            basePriceTextBox.BackColor = Color.Red;
            amountDueTextBox.BackColor = Color.Red;
        }
    }
}
