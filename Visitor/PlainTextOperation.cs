using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
    public class PlainTextOperation : IOperation
    {
        public void Apply(HeadingNode node)
        {
            System.Console.WriteLine("text heading");
        }

        public void Apply(AnchorNode node)
        {
            System.Console.WriteLine("text anchor");
        }
    }
}