using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Visitor.WavFile
{
    public class ReduceNoiseOperation : IOperation
    {
        public void Apply(FormatSegment formatSegment)
        {
            System.Console.WriteLine("Reduce noise for format segment");
        }

        public void Apply(FactSegment factSegment)
        {
            System.Console.WriteLine("Reduce noise for fact segment");
        }
    }
}