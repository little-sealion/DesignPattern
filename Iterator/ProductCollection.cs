using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.IIterator;

namespace DesignPattern.Iterator
{
    public class ProductCollection
    {
        private List<Product> _products = new();
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public IIterator<Product> CreateIterator()
        {
            return new ListIterator(this);
        }

        private class ListIterator : IIterator<Product>
        {
            private ProductCollection _productCollection;
            private int _index;

            public ListIterator(ProductCollection productCollection)
            {
                _productCollection = productCollection;
            }

            public Product Current()
            {
                return _productCollection._products.ElementAt(_index);
            }

            public bool HasNext()
            {
                return _index < _productCollection._products.Count;
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}