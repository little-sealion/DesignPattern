using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility
{
    public class Encryptor : Handler
    {
        public Encryptor(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            System.Console.WriteLine("Encryption");
            return true;
        }
    }
}