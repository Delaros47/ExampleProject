﻿using ExampleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Access
{
    public class ProductDal:IProductDal
    {
        List<Product> _products;
        public ProductDal()
        {
            _products = new List<Product>()
            {
                new Product{ProductId=1,ProductName="Monitor",QuantityPerUnit="In a box",UnitPrice=1450,UnitsInStock=249},
                new Product{ProductId=2,ProductName="RAM",QuantityPerUnit="In a box",UnitPrice=540,UnitsInStock=320},
                new Product{ProductId=3,ProductName="Camera",QuantityPerUnit="In a box",UnitPrice=180,UnitsInStock=541},
            };
        }

        public void Add(Product product)
        {
            Console.WriteLine("Ado.NET has added... ");
        }

        public List<Product> GetAll()
        {
            return _products;
        }
    }
}
