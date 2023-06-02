using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class ProductAddContext : IProductAdd
    {
        IProductAdd dress = new Dress();
        IProductAdd pants = new Pants();
        IProductAdd tshirt = new Tshirt();

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
