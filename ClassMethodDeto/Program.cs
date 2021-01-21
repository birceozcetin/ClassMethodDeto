using System;

namespace ClassMethodDeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customer1 = new Customers();
            Customers customer2 = new Customers();
            Customers customer3 = new Customers();
            customer1.customersName = "James";
            customer1.customersSurname = "Dudley";
            customer1.customersAge = 43;
            customer1.ID = 2888933;

            customer2.customersName = "Hannah";
            customer2.customersSurname = "Cyrus";
            customer2.customersAge = 33;
            customer2.ID = 4783133;

            customer3.customersName = "Jason";
            customer3.customersSurname = "Miller";
            customer3.customersAge = 73;
            customer3.ID = 2737731;

            Management managements = new Management();

            managements.AddCustomers(customer1);
            managements.AddCustomers(customer2);
            managements.AddCustomers(customer3);

            Console.WriteLine(".........................................");

            managements.DeleteCustomers(customer2);
            Console.WriteLine(".........................................");

            Customers[] customers = new Customers[] {customer1,customer2,customer3 };

            managements.ListCustomers(customers);


        }
    }
}
