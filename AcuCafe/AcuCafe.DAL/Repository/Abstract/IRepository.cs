using System.Collections.Generic;

namespace AcuCafe.DAL.Repository.Abstract
{
    public interface IRepository
    {
        IList<string> ReadToppings();
    }
}
