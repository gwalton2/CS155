using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    class MarshmallowAlien : Alien
    {
        public MarshmallowAlien(int health, string name) : base(health, name) { }

        public override int GetDamage()
        {
            return 1;
        }
    }
}
