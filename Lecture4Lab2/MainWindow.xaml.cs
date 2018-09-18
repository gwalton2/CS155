//authors: Grant Walton & Julie Bonsack
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

namespace Lecture4Lab2
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
            int fine = 0;

            int limit = Int32.Parse(limitInput.Text);
            int speed = Int32.Parse(speedInput.Text);

            if (speed > limit)
            {
                fine += 60;

                if (speed > (limit + 25))
                {
                    fine += 250;
                    colorCanvas.Background = Brushes.Red;
                }
                else
                {
                    colorCanvas.Background = Brushes.Yellow;
                }

                fine += (speed - limit) * 7;
                fineOutput.Text = fine.ToString("C");
            }

            else
            {
                fineOutput.Text = "$0.00";
                colorCanvas.Background = Brushes.Green;
            }
        }
    }
}
