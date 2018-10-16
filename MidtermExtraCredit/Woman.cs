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

        public void SetEngaged(Man man)
        {
            engaged = man;
        }

        public string GetEngaged()
        {
            return engaged.GetName();
        }

        public string GetName()
        {
            return name;
        }

        public bool Prefer(Man man)
        {
            if (null != engaged)
            {
                foreach (Man m in rank)
                {
                    if (m.Equals(man))
                    {
                        engaged.ChangeStatus();
                        return true;
                    }
                    if (m.Equals(engaged))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
