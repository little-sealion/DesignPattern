using System;
namespace DesignPattern.Bridge
{
    public class BlackPen : Pen
    {
        public BlackPen(Ruler ruler):base(ruler)
        {

        }
        public override void Draw()
        {
            Console.Write("Black ");
            this.ruler.regularize();
        }
    }
}

