using System;
using System.Collections.Generic;
using System.Text;

namespace PasaDevGaming.ControlDatabase
{
    public class EdevletDatabase
    {
        public List<Customer> ReturnOfCustomers()
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.TcNumber = "12345678912";
            customer1.FirstName = "Furkan";
            customer1.LastName = "TOPAL";
            customer1.BirthYear = "2002";

            List<Customer> customers = new List<Customer>
            {
                customer1
            };
            return customers;
        }
    }
}
