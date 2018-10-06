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
