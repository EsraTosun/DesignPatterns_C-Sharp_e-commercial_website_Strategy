﻿using System;
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

    class Seller : User, ISeller
    {
        int transaction = -1;
        public static int index = 0;

        public static ProductAddContext productAddContext = new ProductAddContext();
        public static ProductDeleteContext productDeleteContext = new ProductDeleteContext();
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
    }
}
