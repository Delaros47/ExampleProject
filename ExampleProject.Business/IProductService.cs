using ExampleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Business
{
    public interface IProductService
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        Task<List<Product>> GetAllAsync();
        Task AddAsync(Product product);
    }
}
