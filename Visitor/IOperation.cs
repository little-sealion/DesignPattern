using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
    public interface IOperation
    {
        void Apply(HeadingNode node);
        void Apply(AnchorNode node);
    }
}