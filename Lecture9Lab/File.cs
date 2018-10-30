using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Lab
{
    class File : Document
    {
        private string pathname;

        public File() : base()
        {
            pathname = "";
        }

        public File(string pathname, string text) : base(text)
        {
            this.pathname = pathname;
        }

        public void SetPath(string pathname)
        {
            this.pathname = pathname;
        }

        public string GetPath(string pathname)
        {
            return pathname;
        }

        public override string ToString()
        {
            return pathname + "\n" + base.ToString();
        }
    }
}
