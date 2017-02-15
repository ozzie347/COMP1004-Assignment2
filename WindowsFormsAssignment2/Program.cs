/**
App: COMP1004-Assignment2
Author: Nicholas Oshukany
Last Modified: 02/12/2017
Description: This program calculates the amount due on a new or used vehicle
*/

using System;
using System.Windows.Forms;

namespace WindowsFormsAssignment2
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
            Application.Run(new AutoCenterForm());
        }
    }
}
