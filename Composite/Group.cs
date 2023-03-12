using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Composite
{
    public class Group : IComponent
    {
        private List<IComponent> _components = new();

        public void Add(IComponent component)
        {
            _components.Add(component);
        }

        public void Move()
        {
            foreach (var component in _components)
            {
                component.Move();
            }
        }

        public void Render()
        {
            foreach (var component in _components)
            {
                component.Render();
            }
        }
    }
}