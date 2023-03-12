using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Visitor.WavFile
{
    public class FactSegment : ISegment
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}