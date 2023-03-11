using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    public class Canvas
    {
        public Tool CurrentTool { get; set; } = null!;
        public void MouseDown()
        {
            CurrentTool.MouseDown();
        }
        public void MouseUp()
        {
            CurrentTool.MouseUp();
        }
    }
}