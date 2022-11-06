using System;
namespace DesignPattern.Proxy
{
    public class Modem:Internet
    {
        public Modem(string password)
        {
            if(password != "123456")
            {
                throw new Exception("Failed to dial, please try again");
            }
            Console.WriteLine("Dialing .... Successfully connected!");
        }

        public void httpAccess(string url)
        {
            Console.WriteLine($"Visiting {url}");
        }
    }
}

