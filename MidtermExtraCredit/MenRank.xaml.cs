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
    /// Interaction logic for MenRank.xaml
    /// </summary>
    public partial class MenRank : Page
    {
        int pointer = 0;
        string[] maleNames;
        string[] femaleNames;

        string[][] maleRank;

        public MenRank(string[] maleNames, string[] femaleNames)
        {
            InitializeComponent();

            this.maleNames = maleNames;
            this.femaleNames = femaleNames;
            this.maleRank = new string[maleNames.Length][];

            group2Text.Text = string.Join(", ", femaleNames);
            nameText.Text = maleNames[pointer];
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            string[] ranks = rankText.Text.Split(',');
            if (ranks.Length != maleNames.Length)
            {
                MessageBox.Show("Please include all female names");
            }
            else
            {
                for (int i = 0; i < maleNames.Length; i++)
                {
                    ranks[i] = ranks[i].Trim();
                }

                maleRank[pointer] = ranks;
                pointer++;

                if (pointer == maleRank.Length)
                {
                    nextButton.IsEnabled = false;
                    finishButton.IsEnabled = true;
                }
                else
                {
                    nameText.Text = maleNames[pointer];
                }
            }
        }

        private void finishButton_Click(object sender, RoutedEventArgs e)
        {
            WomenRank womenrankPage = new WomenRank(maleNames, femaleNames, maleRank);
            this.NavigationService.Navigate(womenrankPage);
        }
    }
}
