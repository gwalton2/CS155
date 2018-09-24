/// Homework No.4 Exercise No.1
/// File Name: MainWindow.xaml.cs
/// @author: Grant Walton
/// Date: Sept. 24, 2018
/// Problem Statement: This program should calculate a user's bmi based off of their weight and height
/// and also communicate if their bmi is above, below, or within a healthy range. 
/// Overall Plan:
/// 1. I will build a GUI that allows for the input and output of the necessary information.
/// 2. I will take in the user's weight and height throught textboxes.
/// 3. Once the calculate button is pressed, I will display the user's bmi in a textbox using
/// bmi = (weight * 720)/(height^2)
/// 4. I will also use a canvas to change color depending on their bmi. Blue if it is below the 
/// healthy range(less than 15), green if it is within, and yellow if it is above(greater than 26).
/// 5. In addition to the colors I will print out a message in a textbox indicating what each color
/// means. The three possiblities will be handled with conditionals.

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
