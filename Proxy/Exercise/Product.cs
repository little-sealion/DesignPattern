using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Proxy.Exercise
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; protected set; } = null!;
        public Product(int id)
        {
            Id = id;
        }

        public virtual void SetName(string name)
        {
            Name = name;
        }
    }
}