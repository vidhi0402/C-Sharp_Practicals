using System;

namespace SRP_Practical7
{ 
    class Program
    {
        class User  //User Class has Responsibility of User 
        {
            public void UserResigration()
            {
                //user registration logic
                Console.WriteLine("This is User Registration Method");
            }
            public void UserLogin()
            {
                //user login logic
                Console.WriteLine("This is User Login Method");
            }
            //public void OrderDetail() user class does not have responsibility of order so
            // we need to create a seprate class Order for Order Detals... so that follow SRP priciple. 

        }
        class Order  //Order Class has Responsibility of Order 
        {
            public void OrderDetail()
            {
                //Details about Order
                Console.WriteLine("This is Order Detail Method");
            }
        }
        static void Main(string[] args)
        {
            User u = new User();
            Order o = new Order();
            u.UserResigration();
            u.UserLogin();
            o.OrderDetail();
        }
    }
}