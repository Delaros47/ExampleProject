﻿using ExampleProject.Access;
using ExampleProject.Business;













ProductManager productManager = new ProductManager(new EfProductDal());
foreach (var product in productManager.GetAll())
{
    Console.WriteLine(product.ProductName);
}








Console.ReadLine();