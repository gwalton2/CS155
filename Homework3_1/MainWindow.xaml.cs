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
