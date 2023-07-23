using toDoList.Data;
using System.Configuration;
using System;

//var x = ConfigurationManager.ConnectionStrings;
//Console.WriteLine(x["MyDbConnection"]);
class Program
{
    static void Main(string[] args)
    {
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        var connectionString = config.ConnectionStrings.ConnectionStrings["taskDbConnection"].ToString();
        var context = new TasksContext(connectionString);

        //Console.WriteLine(context.Products.Count());
        //var prod = new Products
        //{
        //    ProductId = 3,
        //    Name = "Queijo",
        //    UnitPrice = (decimal)10,
        //    Description = "Coalho",
        //    CategoryId = 1
        //};

        //context.Products.Add(prod);
        //context.SaveChanges();
    }
}