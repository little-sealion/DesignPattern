using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility.DataReader
{
    public class NumbersReader : DataReader
    {
        private const string Numbers = "numbers";

        protected override void DoRead(File file)
        {
            System.Console.WriteLine("Reading & processing numbers file");
        }

        protected override string GetExtension()
        {
            return Numbers;
        }
    }
}