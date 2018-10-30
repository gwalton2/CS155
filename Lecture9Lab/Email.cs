using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Lab
{
    class Email : Document
    {
        private string sender;
        private string recipient;
        private string title;

        public Email() : base()
        {
            sender = "";
            recipient = "";
            title = "";
        }

        public Email(string sender, string recipient, string title, string text) : base(text)
        {
            this.sender = sender;
            this.recipient = recipient;
            this.title = title;
        }

        public void SetSender(string sender)
        {
            this.sender = sender;
        }

        public void SetRecipient(string recipient)
        {
            this.recipient = recipient;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public override string ToString()
        {
            string header =  "Title: " + title + "\nSender: " + sender + "\nRecipient: " + recipient + "\n";
            return header + base.ToString();
        }
    }
}
