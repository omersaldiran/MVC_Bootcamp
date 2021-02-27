﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Id = 1;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            product1.CategoryId = 2;

            Product product2 = new Product() { Id = 2, CategoryId = 3, ProductName = "Kalem", UnitPrice = 35, UnitsInStock = 5 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product2);
            
            Console.ReadKey();

        }
    }
}
