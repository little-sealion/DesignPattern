using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class AESEncryptor : IEncryptor
    {
        public void Encrypt(string message)
        {
            System.Console.WriteLine($"Encrypting message: {message} using AES algorithm");
        }
    }
}