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

namespace MidtermExtraCredit
{
    /// <summary>
    /// Interaction logic for StableMarriageNames.xaml
    /// </summary>
    public partial class StableMarriageNames : Page
    {
        public StableMarriageNames()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            string[] maleNames = malenamesText.Text.Split(',');
            string[] femaleNames = femalenamesText.Text.Split(',');

            if (maleNames.Length != femaleNames.Length)
            {
                MessageBox.Show("Invalid Input. List of names must be same length for each group");
            }
            else
            {
                for (int i = 0; i < maleNames.Length; i++)
                {
                    maleNames[i] = maleNames[i].Trim();
                    femaleNames[i] = femaleNames[i].Trim();
                }

                MenRank menrankPage = new MenRank(maleNames, femaleNames);
                this.NavigationService.Navigate(menrankPage);
            }
        }
    }
}
