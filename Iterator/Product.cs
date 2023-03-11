using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Iterator
{
    public class Product
    {
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public override string ToString()
        {
            return "Product{" +
                        "id=" + _id +
                        ", name='" + _name + '\'' +
                        '}';
        }
    }
}