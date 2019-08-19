using AcuCafe.DAL.Repository.Abstract;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AcuCafe.DAL.Repository.Concrete
{
    public class Repository: IRepository
    {
        private string _path;
        private IList<string> ListOfFileToppings { get; set; }

        public Repository()
        {
            _path = @"C:\Users\amrit.heer\source\repos\acumen\AcuCafe\Toppings.txt";//data source
            ReadToppings();
        }

        public IList<string> ReadToppings()
        {
            return File.ReadLines(_path).ToList();
        }
    }
}