/// Homework No.12 Exercise No.1
/// File Name: MainWindow.xaml.cs
/// @author: Grant Walton
/// Date: Dec. 3, 2018
/// Problem Statement: This program should use a GUI to display buttons allowing the user to select a shape
/// and a button to calculate the area of the selected shape.
/// Overall Plan:
/// 1. I will first build the GUI by placing a button for each shape and one button for performing the calculation.
/// I will finish up the GUI by placing a textbox to display the calculated area.
/// 2. On the backend I will create a method to calculate the area of each shape. 
/// 3. I will then create a delegate that takes in the same type of inputs and has the same return types
/// of the area methods.
/// 4. Then in each of the shape buttons methods I will assign the delegate to the corresponding method.
/// 5. For the area buttons method I will call the delegate on the saved inputs for the correct shape if the 
/// delegate has been assigned.
/// 6. The return will then be displayed in the textbox.

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

namespace Homework12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int SqBase = 5;
        const int TriBase = 4;
        const int CrRadius = 6;

        private delegate double AreaDelegate(int i);
        AreaDelegate areaMethod;
        private int input;

        public MainWindow()
        {
            InitializeComponent();
        }

        private double SquareArea(int _base)
        {
            return Math.Pow(_base, 2);
        }

        private double TriangleArea(int _base)
        {
            return Math.Pow(_base, 2) / (double)2;
        }

        private double CircleArea(int radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        private void squareButton_Click(object sender, RoutedEventArgs e)
        {
            areaMethod = SquareArea;
            input = SqBase;
        }

        private void triangleButton_Click(object sender, RoutedEventArgs e)
        {
            areaMethod = TriangleArea;
            input = TriBase;
        }

        private void circleButton_Click(object sender, RoutedEventArgs e)
        {
            areaMethod = CircleArea;
            input = CrRadius;
        }

        private void areaButton_Click(object sender, RoutedEventArgs e)
        {
            if (areaMethod != null)
            {
                textOutput.Text = areaMethod(input).ToString();
            }
            else
            {
                textOutput.Text = "";
            }
        }
    }
}
