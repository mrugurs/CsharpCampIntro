﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStok = 3;

            Product product2 = new Product {Id = 2, CategoryId = 5, UnitsInStok = 5, ProductName = "Kalem", UnitPrice = 35};

            //case sensitive - Küçük Büyük harf duyarlı
            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //int sayi = 100;
            //productManager.BirseyYap(sayi);
            //Console.WriteLine(sayi);

            //int, double,bool... değer tip
            //diziler, class, abstract class, interface... referans tip
            //ref out

            //productManager.Topla2(3, 6);

            //int toplamaSonucu = productManager.Topla(3, 6);
            //Console.WriteLine(toplamaSonucu * 2);
        }
    }
}
