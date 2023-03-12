using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Visitor.WavFile
{
    public class AddReverbOperation : IOperation
    {
        public void Apply(FormatSegment formatSegment)
        {
            System.Console.WriteLine("Add reverb for format segment");
        }

        public void Apply(FactSegment factSegment)
        {
            System.Console.WriteLine("Add reverb for fact segment");
        }
    }
}