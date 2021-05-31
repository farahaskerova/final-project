using ConsoleTables;
using Final_Project.servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class MenuServer
    {
        static Markservers markserver = new();

        public static void DisplayMenuProducts()
        {
            var table = new ConsoleTable("Price", "Name", "categories", "Code");

            foreach (var products in markserver.Products)
            {
                table.AddRow(products.Price, products.Name, products.categories, products.Code.ToString());// "#.00"
            }
            table.Write();
            Console.WriteLine();
        }
        public static void DisplayMenuSales()
        {
            var table = new ConsoleTable("Price", "Date", "No", "SaleItem");

            foreach (var sales in markserver.Sale)
            {
                table.AddRow(sales.Price, sales.No, sales.SaleItems, sales.Date);
            }
            table.Write();
            Console.WriteLine();
        }
        public static void AddMenuProducts()
        {
            Console.WriteLine("Enter product name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter product price");
            double Price = double.Parse(Console.ReadLine());
            Console.WriteLine("enter product categories");
            Categories categories = Enum.Parse<Categories>(Console.ReadLine());
            Console.WriteLine("Enter product code");
            int Code = int.Parse(Console.ReadLine());
            //markserver.AddNewProducts(Name, Price, categories);







            #region Delete Menus
            //public static void DeleteItem(string type)
            //{
            //    Console.WriteLine("Insert no");
            //    string noStr = Console.ReadLine();
            //    try
            //    {
            //        switch (type)
            //        {
            //            case "Products":
            //                Markservers.DeleteProducts(int.Parse(noStr));
            //                break;
            //            case "Sales":
            //                Markservers.DeleteSales(int.Parse(noStr));

            //                break;
            //            default:
            //                break;
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("Please try again");
            //        Console.WriteLine(e.Message);
            //    }
            //}
            #endregion
        }
    }
}    
