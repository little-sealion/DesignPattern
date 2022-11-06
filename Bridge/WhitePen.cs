
using System;
namespace DesignPattern.Bridge
{
    public class WhitePen:Pen
    {
        public WhitePen(Ruler ruler):base(ruler)
        {
        }

        public override void Draw()
        {
            Console.Write("White ");
            this.ruler.regularize();
        }
    }
}

