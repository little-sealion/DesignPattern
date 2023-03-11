using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class ChatClient
    {
        public void Send(string message, IEncryptor encriptor)
        {
            encriptor.Encrypt(message);
            System.Console.WriteLine($"sending message: {message}");
        }
    }
}