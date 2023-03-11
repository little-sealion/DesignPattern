using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class ImageStorage
    {


        public void Store(string image, ICompressor compressor, IFilter filter)
        {
            compressor.Compress(image);
            filter.Apply(image);
            System.Console.WriteLine($"Saving {image} ...");
        }
    }
}