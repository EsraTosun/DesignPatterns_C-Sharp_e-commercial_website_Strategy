using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    enum SellerAccountType   //Satıcı hesap tipleri
    {
        AccountInformation = 1,
        ViewYourProducts = 2,
        AddProduct = 3,
        DeleteProduct = 4,
        Logout = 5,
    }

    class Seller : User, ISeller, IUserAdd
    {
        int transaction = -1;
        public static int index = 0;

        public static IProductAdd productAddContext = new ProductAddContext();
        public static IProductDelete productDeleteContext = new ProductDeleteContext();
        public static String productsType;

        public static Products products = new Products();
        public static UserTransacions userTransacions = new UserTransacions();

        public static int DesiredID;
        public void AccountInformation()
        {
            UserTransacions.SellerUser();         
        }

        public void AddProduct()
        {
            productsType  = Seller.productsTypeFinding();
            productAddContext.ProductAdd();
        }

        public void DeleteProduct()  //Ürün tipi
        {
            Console.WriteLine("Delete ID: ");
            DesiredID = Convert.ToInt32(Console.ReadLine());
            index = Products.productList.FindIndex(r => r.ID == Seller.DesiredID);
            productDeleteContext.ProductDelete();
        }

        public void ViewYourProducts()
        {
            products.SellerProductsList();
        }

        public static String productsTypeFinding()
        {
            int transactions;
            while (true)
            {
                Console.WriteLine("1- " + ProductsType.pants);
                Console.WriteLine("2- " + ProductsType.tshirt);
                Console.WriteLine("3- " + ProductsType.dress);
                transactions = Convert.ToInt32(Console.ReadLine());

                return Products.ProductsTypelist[transactions];
            }
        }

        public void UserAdd()
        {
            User passing = new User();

            Console.WriteLine("Name your enter");
            passing.Name = Console.ReadLine();
            Console.WriteLine("Surname your enter");
            passing.Surname = Console.ReadLine();
            Console.WriteLine("E-mail your enter");
            passing.EmailAddress = Console.ReadLine();
            Console.WriteLine("Password your enter");
            passing.Password = Console.ReadLine();
            Console.WriteLine("Phonename your enter");
            passing.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Adress your enter");
            passing.Adress = Console.ReadLine();
            login = true;

            passing.ID = SellerList.Count + 200;
            USERID = SellerList.Count + 200;
            SellerList.Add(passing);
        }
    }
}
