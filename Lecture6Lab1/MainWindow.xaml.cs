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

namespace Lecture6Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listBox.Items.Add("+");
            listBox.Items.Add("-");
            listBox.Items.Add("*");
            listBox.Items.Add("/");
            listBox.Items.Add("%");
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            int first_val = 0;
            int sec_val = 0;
            int output = 0;

            try
            {
                first_val = Int32.Parse(firstInput.Text);
                sec_val = Int32.Parse(secInput.Text);
                string oper = (string)listBox.SelectedItem;

                switch (oper)
                {
                    case "+":
                        output = first_val + sec_val;
                        break;

                    case "-":
                        output = first_val - sec_val;
                        break;

                    case "*":
                        output = first_val * sec_val;
                        break;

                    case "/":
                        output = first_val / sec_val;
                        break;

                    case "%":
                        output = first_val % sec_val;
                        break;

                    default:
                        MessageBox.Show("Invalid Input. Select operation");
                        break;
                }

                calcOutput.Text = output.ToString();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Can't divide by zero");
                calcOutput.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input");
                calcOutput.Text = "";
            }
        }
    }
}
