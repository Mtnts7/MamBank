using System;

namespace MamBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = "1";
            customer1.CustomerName = "Mehmet Ali Metintaş";
            customer1.TcKimlikNo = "12345678901";

            Customer customer2 = new Customer();
            customer2.CustomerId = "2";
            customer2.CustomerName = "Mehmet Metintaş";
            customer2.TcKimlikNo = "22345678901";

            Customer customer3 = new Customer();
            customer3.CustomerId = "3";
            customer3.CustomerName = "Ali Metintaş";
            customer3.TcKimlikNo = "32345678901";


            Customer[] customers = new Customer[] {customer1,customer2,customer3 };

            

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Delete(customer1);
            customerManager.Listele(customers);


        }
        

    }
}