using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_playground
{
    public class ProductLocation
    {
        private Dictionary<Guid, string> _products;

        public ProductLocation(Dictionary<Guid, string> data)
        {
            _products = data;
        }

        public Guid AddProduct(string location)
        {
            var Id = Guid.NewGuid();
            _products.Add(Id, location);
            return Id;
        }

        public void DeleteProduct(Guid Id)
        {
            if (_products.ContainsKey(Id))
                _products[Id] = null;
        }

        public string GetProductLocation(Guid Id)
        {
            if (_products.ContainsKey(Id))
                return _products[Id];

            return "Wrong Item";
        }

        public void PrintProducts()
        {
            Console.WriteLine("All products :");
            if(_products.Count == 0)
                return;            

            foreach (var product in _products)
            {
                if(product.Value != null)
                    Console.WriteLine($"{product.Key} - {product.Value}");
            }
        }
    }
}
