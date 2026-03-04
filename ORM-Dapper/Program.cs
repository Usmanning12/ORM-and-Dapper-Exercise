using System.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace ORM_Dapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection conn = new MySqlConnection(connString);

            var repo = new DapperProductRepository(conn);
            
            Console.WriteLine("What is the name of your new product?");
            var productName = Console.ReadLine(); 
            
            Console.WriteLine("What is the price?");
            var productPrice = double.Parse(Console.ReadLine());
            
            Console.WriteLine("What is the category ID?");
            var categoryID = int.Parse(Console.ReadLine());
            
            repo.CreateProduct(productName, productPrice, categoryID);
            
            repo.CreateProduct(productName, productPrice, categoryID);
            
            var products = repo.GetAllProducts();

            foreach (var prod in products)
            {
                Console.WriteLine($"{prod.ProductId}- {prod.ProductName}");
            }



        }
    }
}
