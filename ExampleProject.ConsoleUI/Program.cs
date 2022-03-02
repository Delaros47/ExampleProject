using ExampleProject.Access;
using ExampleProject.Business;
using ExampleProject.Entities;




//ProductManager productManager = new ProductManager(new EfProductDal());
//foreach (var product in productManager.GetAll())
//{
//    Console.WriteLine(product.ProductName);
//}

PersonelManager personelManager = new PersonelManager(new EfPersonelDal());
foreach (var item in personelManager.GetAll())
{
    Console.WriteLine($"{item.Name,-15} {item.Surname,-15}");
}





Console.ReadLine();