using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class Person
    {
        private string name;

        public Person()
        {
            name = "";
        }

        public Person(string name)
        {
            this.name = name;
        }

        public Person(Person obj)
        {
            name = obj.GetName();
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }

        public override bool Equals(object obj)
        {
            Person other = (Person)obj;
            return name.Equals(other.GetName());
        }
    }
}
