using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; 

namespace PolimorfismoProduto.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }


       

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee= customsFee;
        }
        
        public double totalPrice()
        {
            return Price * CustomsFee;
        }

        public override string priceTag()
        {
            return base.Name
                + " R$ "
                + "(Customs fee: R$ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + " )"; 
        }

        

    }
}
