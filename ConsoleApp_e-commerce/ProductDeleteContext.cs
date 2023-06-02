using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class ProductDeleteContext : IProductDelete
    {
        Dress dress = new Dress();
        Pants pants = new Pants();
        Tshirt tshirt = new Tshirt();

        public void ProductDelete()
        {
            if (Products.productList[Seller.index].productType.Equals("dress"))
            {
                dress.ProductDelete();
            }
            else if (Products.productList[Seller.index].productType.Equals("tshirt"))
            {
                tshirt.ProductDelete();
            }
            else
            {
                pants.ProductDelete();
            }
        }
    }
}
