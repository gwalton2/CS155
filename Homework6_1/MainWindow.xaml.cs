/// Homework No.6 Exercise No.1
/// File Name: MainWindow.xaml.cs
/// @author: Grant Walton
/// Date: Oct. 6, 2018
/// Problem Statement: This program should implement and test a class called Counter whose objects
/// count positive integers in increments of 1. It can only be set to zero and it cannot count below zero.
/// Overall Plan:
/// 1. I will create an integer variable in the Counter class that contains the actual count.
/// 2. I will implement the SetZero, AddOne, DecreaseOne, GetCount, PrintCount, Equals, and ToString
/// methods of the class with simple operations on the count variable. 
/// 3. I will build the driver program by making a GUI that contains a menu of all the methods
/// for the Counter class and you can select each method on two different Counter objects(except for
/// the Equals method as there will only be one option for that which compares the two objects).
/// 4. The GUI will display the values of a string and integer variable for each object which are
/// set to the values returned from the GetCount and ToString methods for their respective objects.
/// 5. The PrintCount method will still print out to the Console as intended. The results of pressing 
/// this button be seen upon closing the GUI in the console.
/// 6. Behind the scenes, the GUI will work by creating two different Counter objects and calling 
/// their methods for each respective button. There will be two int variables and two string 
/// variables. One of each will be associated with a Counter object and then be set to the output
/// of its ToString and GetCount methods. These methods will also update the GUI to display the
/// value of the associated variable. 
/// 7. The GUI will display True or False when the Equal button is pressed depending on the boolean
/// returned from calling the Equal method of one Counter object with the other object as the 
/// parameter.

/// Classes needed and Purpose: Only main class is needed
/// main class - Main Window : Window
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

namespace Homework6_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Counter mycount1 = new Counter();
        int int_count1;
        string st_count1;

        Counter mycount2 = new Counter();
        int int_count2;
        string st_count2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetZero1_Click(object sender, RoutedEventArgs e)
        {
            mycount1.SetZero();
        }

        private void AddOne1_Click(object sender, RoutedEventArgs e)
        {
            mycount1.AddOne();
        }

        private void DecreaseOne1_Click(object sender, RoutedEventArgs e)
        {
            mycount1.DecreaseOne();
        }

        private void GetCount1_Click(object sender, RoutedEventArgs e)
        {
            int_count1 = mycount1.GetCount();
            int1Text.Text = int_count1.ToString();
        }

        private void PrintCount1_Click(object sender, RoutedEventArgs e)
        {
            mycount1.PrintCount();
        }

        private void ToString1_Click(object sender, RoutedEventArgs e)
        {
            st_count1 = mycount1.ToString();
            string1Text.Text = st_count1;
        }

        private void SetZero2_Click(object sender, RoutedEventArgs e)
        {
            mycount2.SetZero();
        }

        private void AddOne2_Click(object sender, RoutedEventArgs e)
        {
            mycount2.AddOne();
        }

        private void DecreaseOne2_Click(object sender, RoutedEventArgs e)
        {
            mycount2.DecreaseOne();
        }

        private void GetCount2_Click(object sender, RoutedEventArgs e)
        {
            int_count2 = mycount2.GetCount();
            int2Text.Text = int_count2.ToString();
        }

        private void PrintCount2_Click(object sender, RoutedEventArgs e)
        {
            mycount2.PrintCount();
        }

        private void ToString2_Click(object sender, RoutedEventArgs e)
        {
            st_count2 = mycount2.ToString();
            string2Text.Text = st_count2;
        }

        private void equalsButton_Click(object sender, RoutedEventArgs e)
        {
            if (mycount1.Equals(mycount2))
            {
                equalText.Text = "True";
            }
            else
            {
                equalText.Text = "False";
            }
        }
    }
}
