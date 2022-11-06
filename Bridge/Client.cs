using System;
namespace DesignPattern.Bridge
{
    public class Client
    {
        public static void main()
        {
            new WhitePen(new CircleRuler()).Draw();
            new WhitePen(new TriangleRuler()).Draw();
            new WhitePen(new SquareRuler()).Draw();

            new BlackPen(new CircleRuler()).Draw();
            new BlackPen(new TriangleRuler()).Draw();
            new BlackPen(new SquareRuler()).Draw();
        }
    }
}

