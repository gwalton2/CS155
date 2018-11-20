using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Lab1
{
    class NameInfo
    {
        private string name;
        private string gender;

        public NameInfo(string name, string gender, int rank, int count)
        {
            this.name = name;
            this.gender = gender;

            Rank = rank;
            Count = count;
        }

        public int Rank { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return name + " is ranked " + Rank + " in popularity amoung " + gender + "s with " + Count + " namings";
        }
    }
}
