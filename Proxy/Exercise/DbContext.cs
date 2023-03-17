using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Proxy.Exercise
{
    public class DbContext
    {
        private Dictionary<int, Product> updatedObjects = new();

        public Product GetProduct(int id)
        {
            // Automatically generate SQL statements
            // to read the product with the given ID.
            System.Console.WriteLine($"SELECT * FROM products WHERE product_id = {id} \n");

            // Simulate reading a product object from a database.
            var product = new ProductProxy(id, this);
            product.SetName("Product 1");

            return product;
        }

        public void SaveChanges()
        {
            // Automatically generate SQL statements
            // to update the database.
            foreach (var updatedObject in updatedObjects.Values)
                System.Console.WriteLine($"UPDATE products SET name = {updatedObject.Name} WHERE product_id = {updatedObject.Id} \n");

            updatedObjects.Clear();
        }

        public void MarkAsChanged(Product product)
        {
            if (!updatedObjects.ContainsKey(product.Id))
                updatedObjects.Add(product.Id, product);
            else
            {
                updatedObjects[product.Id] = product;
            }
        }

    }

}