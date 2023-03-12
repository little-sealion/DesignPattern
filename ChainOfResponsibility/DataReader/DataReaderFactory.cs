using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility.DataReader
{
    public class DataReaderFactory
    {
        public static DataReader GetDataReaderChain()
        {
            var qbwReader = new QBWReader();
            var numbersReader = new NumbersReader();
            var xlsReader = new XLSReader();
            xlsReader.SetNext(numbersReader);
            numbersReader.SetNext(qbwReader);
            return xlsReader;
        }
    }
}