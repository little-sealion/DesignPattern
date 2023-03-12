using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
    public class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode node)
        {
            System.Console.WriteLine("Highlight Heading");
        }

        public void Apply(AnchorNode node)
        {
            System.Console.WriteLine("Highlight Anchor");
        }
    }
}