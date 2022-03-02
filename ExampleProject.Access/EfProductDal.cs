using ExampleProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Access
{
    public class EfProductDal : IProductDal
    {


        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedProduct = context.Entry(product);
                addedProduct.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedProduct = context.Entry(product);
                deletedProduct.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            };
        }

        public Product GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.SingleOrDefault(p=>p.ProductId==id);
            }
        }

        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedProduct = context.Entry(product);
                updatedProduct.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
