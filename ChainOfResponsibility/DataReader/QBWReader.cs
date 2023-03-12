using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility.DataReader
{
    public class QBWReader : DataReader
    {
        private const string QBW = "qbw";

        protected override void DoRead(File file)
        {
            System.Console.WriteLine("Reading & processing QBW file");
        }

        protected override string GetExtension()
        {
            return QBW;
        }
    }
}