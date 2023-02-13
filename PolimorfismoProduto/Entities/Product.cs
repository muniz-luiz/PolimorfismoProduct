using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PolimorfismoProduto.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }


        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product()
        {
        }

        public virtual string priceTag()
        {
            return Name + " R$ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
