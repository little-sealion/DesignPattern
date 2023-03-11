using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class PNGCompressor : ICompressor
    {
        public void Compress(string image)
        {
            System.Console.WriteLine($"Compressing {image} using PNG");
        }
    }
}