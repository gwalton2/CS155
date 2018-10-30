using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Lab
{
    class Document
    {
        private string text;

        public Document()
        {
            text = "";
        }

        public Document(string text)
        {
            this.text = text;
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public override string ToString()
        {
            return text;
        }
    }
}
