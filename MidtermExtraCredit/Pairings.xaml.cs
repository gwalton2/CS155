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
    /// Interaction logic for Pairings.xaml
    /// </summary>
    public partial class Pairings : Page
    {
        string[] maleNames;
        string[] femaleNames;
        string[][] maleRank;
        string[][] femaleRank;
        Man[] men;
        Woman[] women;

        public Pairings(string[] maleNames, string[] femaleNames, string[][] maleRank, string[][] femaleRank)
        {
            InitializeComponent();

            this.maleNames = maleNames;
            this.femaleNames = femaleNames;
            this.maleRank = maleRank;
            this.femaleRank = femaleRank;

            men = new Man[maleNames.Length];
            women = new Woman[femaleNames.Length];

            CreateMales();
            CreateFemales();

            SetMaleranks();
            SetFemaleranks();

            StableMarriage stablemarriage = new StableMarriage(women, men);
            stablemarriage.pair();

            SetText();
        }

        private void CreateMales()
        {
            for (int i = 0; i < maleNames.Length; i++)
            {
                Man m = new Man();
                m.SetName(maleNames[i]);
                men[i] = m;
            }
        }

        private void CreateFemales()
        {
            for (int i = 0; i < femaleNames.Length; i++)
            {
                Woman w = new Woman();
                w.SetName(femaleNames[i]);
                women[i] = w;
            }
        }

        private void SetMaleranks()
        {
            for (int i = 0; i < maleNames.Length; i++)
            {
                Woman[] females = new Woman[femaleNames.Length];
                string[] rank = maleRank[i];

                for (int j = 0; j < rank.Length; j ++)
                {
                    string f = rank[j];
                    
                    foreach (Woman w in women)
                    {
                        if (w.GetName().Equals(f))
                        {
                            females[j] = w;
                            break;
                        }
                    }
                }
                men[i].SetRank(females);
            }
        }

        private void SetFemaleranks()
        {
            for (int i = 0; i < femaleNames.Length; i++)
            {
                Man[] males = new Man[maleNames.Length];
                string[] rank = femaleRank[i];

                for (int j = 0; j < rank.Length; j++)
                {
                    string f = rank[j];

                    foreach (Man m in men)
                    {
                        if (m.GetName().Equals(f))
                        {
                            males[j] = m;
                            break;
                        }
                    }
                }
                women[i].SetRank(males);
            }
        }

        private void SetText()
        {
            String master = "";

            foreach(Woman w in women)
            {
                string match = w.GetName() + " -- " + w.GetEngaged();
                master += (match + "\n");
            }

            pairingsText.Text = master;
        }
    }
}
