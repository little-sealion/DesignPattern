using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Visitor.WavFile
{
    public interface ISegment
    {
        void Execute(IOperation operation);
    }
}