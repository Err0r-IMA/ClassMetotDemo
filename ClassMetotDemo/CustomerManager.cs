using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer is Added : " + customer.Name);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer is deleted : " + customer.Name);
        }

        public void List(Customer[]customers)
        {
            foreach (var item in customers)
            {
                Console.WriteLine("Customer Name is Listed:  " + item.Name );
                Console.WriteLine("Customer SurName is Listed :" + item.Surname);
                Console.WriteLine("Customer id is Listed:" + item.id);
                Console.WriteLine("======================================");
            }
        }

    }
}
