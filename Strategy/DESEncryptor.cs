using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class DESEncryptor : IEncryptor
    {
        public void Encrypt(string message)
        {
            System.Console.WriteLine($"Encrypting message: {message} using DES algorithm");
        }
    }
}