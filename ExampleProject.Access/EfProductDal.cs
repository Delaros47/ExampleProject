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

        public async Task AddAsync(Product product)
        {

            NorthwindContext context = new NorthwindContext();
            var addedProduct = context.Entry(product);
            addedProduct.State = EntityState.Added;
            await context.SaveChangesAsync();

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

        public Task DeleteAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            };
        }

        public Task<List<Product>> GetAllAsync()
        {
            NorthwindContext context = new NorthwindContext();
             return context.Products.ToListAsync();
        }

        public Product GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.SingleOrDefault(p => p.ProductId == id);
            }
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
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

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
