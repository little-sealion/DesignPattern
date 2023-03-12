using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Composite
{
    public interface IComponent
    {
        void Render();
        void Move();
    }
}