using System;
using System.Collections.Generic;
using System.Text;

namespace MamBank
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerId + ":" + customer.CustomerName + " : " + customer.TcKimlikNo + ": " + "Added");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerId + ":" + customer.CustomerName + " : " + customer.TcKimlikNo + ": " + "Deleted");
        }
        public void Listele(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.CustomerId+ ":" + customer.CustomerName+ " : " + customer.TcKimlikNo );

            }

        }
    }
}
