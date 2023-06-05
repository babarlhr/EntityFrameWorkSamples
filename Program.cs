using EntityFrameWorkSample.Data;    //Added to use DatabseContext class
using EntityFrameWorkSample.Models;   //Added to retrieve and write data to database tables  using classes.


namespace EntityFrameWorkSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            using ShopContext context = new ShopContext();   //Using to delete,add and get data from Shop database using its context class.
                                                             //using statemet to properly dispose off context object when we finished using it. 

            Product product = new Product()
            {
                Name = "Test Product",
                LastName ="any",
                Price =12
            };


        }
    }
}