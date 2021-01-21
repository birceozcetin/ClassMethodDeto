using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDeto
{
    class Management
    {
        public void AddCustomers(Customers customers)
        {
            Console.WriteLine("Adding customers .....");
            customers.customersSurname = customers.customersSurname;
            customers.customersName = customers.customersName;
            customers.ID = customers.ID;
            customers.customersAge = customers.customersAge;

        }
        public void ListCustomers(Customers[] customers)
        {
            Console.WriteLine("Listing customers ....");
            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine((i + 1) + ". name : " + customers[i].customersName);
                Console.WriteLine((i + 1) + ". surname : " + customers[i].customersSurname);
                Console.WriteLine((i + 1) + ". age : " + customers[i].customersAge);
                Console.WriteLine((i + 1) + ". ID : " + customers[i].ID);
            }
        }
        public void DeleteCustomers(Customers customers)
        {
            
            Console.WriteLine("Deleting customers ....");

            customers.customersAge = 0;
            customers.customersName = "unknown";
            customers.customersSurname = "unknown";
            customers.ID = 0;
        }
    }
}
