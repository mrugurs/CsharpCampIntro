using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Müşteri Ekle     : 1\n" + "Müşteri Güncelle : 2\n" + "Müşteri Sil      : 3\n" + "Operasyon Numarası Seçiniz: ");
            var operation = Console.ReadLine();

            Console.WriteLine("\n");
            //

            if (operation == "1")
            {
                Customer customer1 = new Customer();

                customer1.CustomerId = "1";

                Console.Write("Müşteri İsmi: ");
                customer1.CustomerFirstName = Console.ReadLine();

                Console.Write("Müşteri Soyismi: ");
                customer1.CustomerLastName = Console.ReadLine();

                Console.Write("Müşteri Yaşı: ");
                customer1.CustomerAge = Console.ReadLine();

                Console.Write("Müşteri Şehri: ");
                customer1.CustomerCity = Console.ReadLine();

                Customer[] customerList = new Customer[]
                {
                    customer1
                };

                //foreach (Customer customer in customerList)
                //{ 
                //    string customers = (customer.CustomerFirstName + " " + customer.CustomerLastName);
                //}
                CustomerManager customerManager = new CustomerManager();
                customerManager.AddCustomer(customer1);

                //customerManager.AddCustomer(customerList:customerList1);

                //Console.Write("\n");

                //

                //Console.WriteLine(" başarıyla eklendi.\n");

                //customerManager.AddCustomer();
            }
            else if (operation == "2")
            {
                

            }
            else if (operation == "3")
            {

            }
            else
            {

            }
        }
    }
}
