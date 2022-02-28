using ExampleProject.Business;














ProductManager productManager = new ProductManager();
foreach (var product in productManager.GetAll())
{
    Console.WriteLine(product.ProductName);
}








Console.ReadLine();