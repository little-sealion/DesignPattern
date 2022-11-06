using System;
namespace DesignPattern.Bridge
{
    public abstract class Pen
    {
        protected Ruler ruler;
        public Pen(Ruler ruler)
        {
            this.ruler = ruler;
        }
        public abstract void Draw();

    }
}

