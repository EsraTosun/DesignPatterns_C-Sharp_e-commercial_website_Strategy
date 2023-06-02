using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class UserAddContext : IUserAdd
    {
        IUserAdd seller = new Seller();
        IUserAdd customer = new Customer();

        public void UserAdd()
        {
            if (User.userType.Equals(UserType.Customer))
            {
                customer.UserAdd();
            }
            else
            {
                seller.UserAdd();
            }
        }
    }
}
