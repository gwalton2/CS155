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

namespace Homework4_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            double weight = Double.Parse(weightInput.Text);
            double height = Double.Parse(heightInput.Text);

            double bmi = Math.Round((weight * 720) / (height * height), 2);

            if (bmi < 15)
            {
                colorCanvas.Background = Brushes.Blue;
                messageOutput.Text = "You are below the healthy limit.";
            }
            else if (bmi > 26)
            {
                colorCanvas.Background = Brushes.Yellow;
                messageOutput.Text = "You are above the healthy limit.";
            }
            else
            {
                colorCanvas.Background = Brushes.Green;
                messageOutput.Text = "You are within the healthy limit!";
            }

            bmiOutput.Text = bmi.ToString();
        }
    }
}
