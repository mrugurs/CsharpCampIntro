using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            //Customer customer1 = new Customer();
            
            //customer1.CustomerId = "1";

            //Console.Write("Müşteri İsmi: ");
            //customer1.CustomerFirstName = Console.ReadLine();

            //Console.Write("Müşteri Soyismi: ");
            //customer1.CustomerLastName = Console.ReadLine();

            //Console.Write("Müşteri Yaşı: ");
            //customer1.CustomerAge = Console.ReadLine();

            //Console.Write("Müşteri Şehri: ");
            //customer1.CustomerCity = Console.ReadLine();

            //Customer customer = new Customer();

            //List<string> customerList = new List<string>
            //{
            //    customer.CustomerFirstName, customer.CustomerLastName
            //};

            //Console.Write("\n");

            //foreach (var customer1 in customerList)
            //{
            //    Console.Write(customer + " ");
            //}

            Console.WriteLine(customer.CustomerFirstName + " " + customer.CustomerLastName + " başarıyla eklendi.\n");

            Program program = new Program();
            

            //Customer[] customers = {customer1};
            //UpdateCustomer(customers);
            ////List<string> custmersList = new List<string> { customer1};
        }

        public void UpdateCustomer()
        {

            CustomerList customerList = new CustomerList();
            customerList.List();

        }

    }
}
