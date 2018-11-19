using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    class Alien
    {
        public int _health; //0 = dead, 100 = full
        public string _name;

        public Alien(int health, string name )
        {
            this._health = health;
            this._name = name;
        }

        public int Health
        {
            get { return _health; }

            set { _health = value; }
        }

        public string Name
        {
            get { return _name; }

            set { _name = value; }
        }

        public virtual int GetDamage()
        {
            return 0;
        }
    }
}
