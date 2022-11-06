using System;
namespace DesignPattern.Bridge
{
    public class TriangleRuler : Ruler
    {
        public void regularize()
        {
            Console.WriteLine("Triangle");
        }
    }
}

