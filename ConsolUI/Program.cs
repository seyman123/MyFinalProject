﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsolUI
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            ProductManager productManager = new ProductManager(new EfProductDal()); 

            foreach (var product in productManager.GetAllByCategoryId(5))
            {
                Console.WriteLine(product.ProductName);   
            }         
            
        }
    }
}