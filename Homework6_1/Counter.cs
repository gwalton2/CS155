using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_1
{
    class Counter
    {
        int count = 0;

        public void SetZero()
        {
            this.count = 0;
        }

        public void AddOne()
        {
            this.count++;
        }

        public void DecreaseOne()
        {
            if (this.count > 0)
            {
                this.count--;
            }
        }

        public int GetCount()
        {
            return this.count;
        }

        public void PrintCount()
        {
            Console.WriteLine(this.count.ToString());
        }

        public override string ToString()
        {
            return this.count.ToString();
        }

        public override bool Equals(object obj)
        {
            Counter new_obj = (Counter)obj;
            return this.count == new_obj.GetCount();
        }
    }
}
