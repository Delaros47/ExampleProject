using ExampleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Access
{
    public class EfProductDal : IProductDal
    {

        List<Product> _products;
        public EfProductDal()
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
            Console.WriteLine("Ef has added...");
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
