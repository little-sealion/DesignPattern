using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class JPGCompressor : ICompressor
    {
        public void Compress(string image)
        {
            System.Console.WriteLine($"Compressing {image} using JPG");
        }
    }
}