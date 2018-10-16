using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExtraCredit
{
    class StableMarriage
    {
        Woman[] women;
        Man[] men;

        public StableMarriage(Woman[] women, Man[] men)
        {
            this.women = women;
            this.men = men;
        }

        public void pair()
        {
            Man m;
            do
            {
                m = GetFree(men);
                Woman w = m.GetChoice();

                while (m.IsFree())
                {
                    if (w.Prefer(m))
                    {
                        w.SetEngaged(m);
                        m.ChangeStatus();
                    }
                    m.Next();
                }

            } while (m != null);
        }

        private Man GetFree(Man[] men)
        {
            foreach (Man m in men)
            {
                if (m.IsFree())
                {
                    return m;
                }
            }
            return null;
        }
    }
}
