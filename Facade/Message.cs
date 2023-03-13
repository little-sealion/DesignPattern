using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    public class Message
    {
        public string Content { get; private set; }
        public Message(string content)
        {
            Content = content;
        }


    }
}