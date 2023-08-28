using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Catalog
    {
        public List<Tuple<string, float, string>> Products =
            new List<Tuple<string, float, string>>();

        public List<Tuple<string, float, string>> GetProdCategory(string category)
        {
            return this.Products
                .Where<Tuple<string, float, string>>(p => p.Item3 == category)
                .ToList();
        }

        public void AddProduct(Tuple<string, float, string> product)
        {
            Products.Add(product);
        }
    }
}
