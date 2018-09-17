/// Homework No.3 Exercise No.1
/// File Name: MainWindow.xaml.cs
/// @author: Grant Walton
/// Date: Sept. 17, 2018
/// Problem Statement: This program should use a GUI to take in a monthly mortgage payment and the outstanding balance
/// then output the amount that goes to interest payment and the amount that goes toward the principal.
/// Overall Plan:
/// 1. I will first build the outline of the GUI by placing labels and textboxes for the inputs and outputs.
/// 2. I will finish up the GUI by placing a title and a button and lining everything up.
/// 3. Within the button's click method I will parse the payment and outstanding balance input as doubles.
/// 4. Then I will check for two edge cases. One being if the payment is less than or equal to the interest
/// and the other being if the payment is greater than or equal to the outstanding + interest amount.
/// 5. The else case is obviously if the payment is between the interest and outstanding balance. In this
/// case I will output the interest payment as the outstanding balance times the monthly rate. After subtracting
/// this from the payment, the remaining amount will be output as the principal payment. 

/// Classes needed and Purpose: Only main class is needed
/// main class - MainWindow : Window
/// Import necessary C# or user-defined packages
/// Create main class and objects needed to implement task

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Homework3_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const double INTEREST = .005325;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double payment = Double.Parse(paymentInput.Text);
            double outstanding = Double.Parse(amountInput.Text);

            double interest = outstanding * INTEREST;

            if (payment <= interest)
            {
                interestOutput.Text = payment.ToString("C");
                principalOutput.Text = "$0.00";
            }

            else if (payment >= interest + outstanding)
            {
                interestOutput.Text = interest.ToString("C");
                principalOutput.Text = outstanding.ToString("C");
            }

            else
            {
                interestOutput.Text = interest.ToString("C");
                principalOutput.Text = (payment - interest).ToString("C");
            }
        }
    }
}
