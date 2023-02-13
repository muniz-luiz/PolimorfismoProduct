using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PolimorfismoProduto.Entities
{
    internal class UsedProducts : Product
    {
        public UsedProducts()
        {
        }
                

        public DateTime ManufacturedDate { get; set; }

        public UsedProducts(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string priceTag()
        {
            return base.Name
                + " (used) "
                + " R$ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date:  " + ManufacturedDate.ToString("dd/MM/yyyy") + " )";

        }


    }
}
