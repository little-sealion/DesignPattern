using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility.DataReader
{
    public class XLSReader : DataReader
    {
        private const string XLS = "xls";

        protected override void DoRead(File file)
        {
            System.Console.WriteLine("Reading & processing xls file");
        }

        protected override string GetExtension()
        {
            return XLS;
        }
    }
}