using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    enum CustomerAccountType
    {
        AccountInformation = 1,
        Products = 2,
        MyBasket = 3,
        Favorites = 4,
        Payment = 5,
        Logout = 6,
    }
    class Customer:User, ICustomer, IUserAdd  //Müşteri
    {
        public static UserTransacions userTransacions = new UserTransacions();
        public static User user = new User();
        public static Products products = new Products();

        public static int DesiredID;

        public static List<String> CustomerAccountTypelist = Enum.GetNames(typeof(CustomerAccountType)).ToList();

        public static int transactionID = -1;
        static int transaction = -1;

        public void AccountInformation()
        {
            UserTransacions.CustomerUser();
        }

        public void ProductsList()    //Ürünler
        {
            products.ProductsList();
            Console.WriteLine("Enter the ID of the product you have selected");
            //Seçtiğiniz ürünün ID'si giriniz
            transactionID = Convert.ToInt32(Console.ReadLine());

            CustomerListTransactions.MyBasketORFavoritesAdd();
        }

        public void MyBaskets()
        {

            MyBasket.MyBasketList();
        }

        public void Favoritess()
        {
            Favorites.FavoritesList();
        }

        public void PaymentTransaction()
        {
            Payment.PaymentListFinding();
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

            passing.ID = CustomerList.Count + 100;
            USERID = CustomerList.Count + 100;
            CustomerList.Add(passing);
        }
    }
}
