using ExampleProject.Access;
using ExampleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Business
{
    public class ProductManager
    {


        public List<Product> GetAll()
        {
            ProductDal productDal = new ProductDal();
            return productDal.GetAll();
        }

    }
}
