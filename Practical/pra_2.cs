using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    class Customer_Account
    {
        string bank_name;
        long customer_accountNo;
        string customer_name;

        public Customer_Account( long customer_accountNo, string customer_name)
        {
            this.customer_accountNo = customer_accountNo; ;
            this.customer_name = customer_name;
        }
        public void printInfo()
        {
            Console.WriteLine("Bank name: {0}",bank_name);
            Console.WriteLine("Customer_accountNo: {0}", customer_accountNo);
            Console.WriteLine("Customer_name: {0}",customer_name);
        }
        public static void Main(string[] arg)
        {
            Customer_Account obj = new Customer_Account(1321424356352, "Vidhi Mehta");
            obj.bank_name = "ICIC Bank";
            obj.printInfo();
        }
    }
    
    
}

