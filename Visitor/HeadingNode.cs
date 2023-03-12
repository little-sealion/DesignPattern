using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
    public class HeadingNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}