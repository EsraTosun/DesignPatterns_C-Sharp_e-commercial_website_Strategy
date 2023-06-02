using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class ProductAddContext : IProductAdd
    {
        Dress dress = new Dress();
        Pants pants = new Pants();
        Tshirt tshirt = new Tshirt();

        public void ProductAdd()
        {
            if(Seller.productsType.Equals("dress"))
            {
                dress.ProductAdd();
            }
            else if(Seller.productsType.Equals("tshirt"))
            {
                tshirt.ProductAdd();
            }
            else
            {
                pants.ProductAdd();
            }
        }
    }
}
