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

namespace Lecture3Lab1
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

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            String pig_name = "";
            String full_name = nameText.Text;

            String[] names = nameText.Text.Split(' ');

            foreach (String raw_name in names)
            {
                String name = raw_name.ToLower();
                String pig;
                if (name.Equals(""))
                {
                    continue;
                }

                else if (name.Length < 2)
                {
                    pig = name.ToUpper() + "ay";
                }

                else
                {
                    pig = name.Substring(1, 1).ToUpper() + name.Substring(2) + name.Substring(0, 1) + "ay";
                }
                pig_name += pig + " ";
            }

            pigText.Text = pig_name;
        }
    }
}
