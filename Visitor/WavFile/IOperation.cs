using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Visitor.WavFile
{
    public interface IOperation
    {
        void Apply(FormatSegment formatSegment);
        void Apply(FactSegment factSegment);

    }
}