﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class SnakeAlien : Alien
    {
        public SnakeAlien(int health, string name) : base(health, name) { }

        public int GetDamage()
        {
            return 10;
        }
    }
}
