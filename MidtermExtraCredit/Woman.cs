using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExtraCredit
{
    class Woman
    {
        string name;
        Man engaged;
        Man[] rank;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetRank(Man[] rank)
        {
            this.rank = rank;
        }

        public void Prefer(Man man)
        {
            if (null == engaged)
            {
                engaged = man;
                man.ChangeStatus();
            }
            else
            {
                foreach(Man m in rank)
                {
                    if (m.Equals(man))
                    {
                        engaged.ChangeStatus();
                        man.ChangeStatus();
                        engaged = man;
                        break;
                    }
                    if (m.Equals(engaged))
                    {
                        break;
                    }
                }
            }
        }
    }
}
