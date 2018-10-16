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
    /// Interaction logic for WomenRank.xaml
    /// </summary>
    public partial class WomenRank : Page
    {
        int pointer = 0;
        string[] maleNames;
        string[] femaleNames;
        string[][] maleRank;

        string[][] femaleRank;

        public WomenRank(string[] maleNames, string[] femaleNames, string[][] maleRank)
        {
            InitializeComponent();

            this.maleNames = maleNames;
            this.femaleNames = femaleNames;
            this.maleRank = maleRank;
            this.femaleRank = new string[femaleNames.Length][];

            group1Text.Text = string.Join(", ", maleNames);
            nameText.Text = femaleNames[pointer];
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            string[] ranks = rankText.Text.Split(',');
            if (ranks.Length != femaleNames.Length)
            {
                MessageBox.Show("Please include all male names");
            }
            else
            {
                for (int i = 0; i < femaleNames.Length; i++)
                {
                    ranks[i] = ranks[i].Trim();
                }

                femaleRank[pointer] = ranks;
                pointer++;

                if (pointer == femaleRank.Length)
                {
                    nextButton.IsEnabled = false;
                    finishButton.IsEnabled = true;
                }
                else
                {
                    nameText.Text = femaleNames[pointer];
                }
            }
        }

        private void finishButton_Click(object sender, RoutedEventArgs e)
        {
            Pairings pairings = new Pairings(maleNames, femaleNames, maleRank, femaleRank);
            this.NavigationService.Navigate(pairings);
        }
    }
}
