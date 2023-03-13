using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Adapter.Email.Gmail
{
    public class GmailClient
    {
        public void Connect()
        {
            System.Console.WriteLine("Connecting to Gmail");
        }

        public void GetEmails()
        {
            System.Console.WriteLine("Downloading emails from Gmail");
        }

        public void Disconnect()
        {
            System.Console.WriteLine("Disconnecting from Gmail");
        }
    }
}