using AcuCafe.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            var repo = new Repository();
            var list = repo.ReadToppings();
            Console.WriteLine(list);
            Console.ReadLine();




            //Console.WriteLine("Please select a drink from the list:");
            //var list = new List<string>
            //{
            //    "1. Americano",
            //    "2. Cappuccino",
            //    "3. Latte",
            //    "4. Mocha"
            //};
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Press the number associated with the drink you would like");
            //var selection = Console.ReadLine();

            //var isNumber = int.TryParse(selection, out _);

            //if (isNumber)
            //{
            //    switch (Convert.ToInt32(selection))
            //    {
            //        case 1:
            //            Console.WriteLine();
            //            break;
            //        case 2:
            //            Console.WriteLine();
            //            break;
            //        case 3:
            //            Console.WriteLine();
            //            break;
            //        case 4:
            //            Console.WriteLine();
            //            break;
            //        default:
            //            Console.WriteLine("Please make a selection from the list:");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter the number for the drink selection:");
            //}
        }
    }
}
