using ExampleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Access
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);

    }
}
