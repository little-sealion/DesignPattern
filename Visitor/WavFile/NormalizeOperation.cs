using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Visitor.WavFile
{
    public class NormalizeOperation : IOperation
    {
        public void Apply(FormatSegment formatSegment)
        {
            System.Console.WriteLine("Normalize format segment");
        }

        public void Apply(FactSegment factSegment)
        {
            System.Console.WriteLine("Normalize fact segment");
        }
    }
}