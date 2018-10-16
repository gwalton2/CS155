using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExtraCredit
{
    class Man
    {
        string name;
        bool free = true;
        int pick_index = 0;
        Woman[] rank;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetRank(Woman[] rank)
        {
            this.rank = rank;
        }

        public string GetName()
        {
            return name;
        }

        public bool IsFree()
        {
            return free;
        }

        public void ChangeStatus()
        {
            free = !free;
        }

        public Woman GetChoice()
        {
            return rank[pick_index];
        }

        public void Next()
        {
            if  (pick_index < rank.Length)
            {
                pick_index++;
            }
        }

        public override string ToString()
        {
            return name;
        }

        public override bool Equals(object obj)
        {
            Man new_man = (Man)obj;
            return name.Equals(new_man.ToString());
        }

    }
}
