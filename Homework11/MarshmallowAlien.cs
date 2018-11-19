using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class MarshmallowAlien : Alien
    {
        public MarshmallowAlien(int health, string name) : base(health, name) { }

        public int GetDamage()
        {
            return 1;
        }
    }
}
