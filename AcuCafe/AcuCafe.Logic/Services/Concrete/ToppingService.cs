using AcuCafe.DAL.Repository.Abstract;
using AcuCafe.Logic.Constants;
using AcuCafe.Logic.Services.Abstract;

namespace AcuCafe.Logic.Services.Concrete
{
    public class ToppingService : IToppingService
    {
        private readonly IRepository _toppingRepository;

        public ToppingService(IRepository toppingRepository)
        {
            _toppingRepository = toppingRepository;
        }

        public string GetToppingFromFile()
        {
            var listOfToppings = _toppingRepository.ReadToppings();

            foreach (var item in listOfToppings)
            {
                switch (item.ToLower())
                {
                    case "chocolate": return Topping.Chocolate;
                    case "white chocolate": return Topping.WhiteChocolate;
                    case "cinnamon": return Topping.Cinnamon;
                    case "semi skimmed milk": return Topping.SemiSkimmedMilk;
                    case "full fat milk": return Topping.FullFatMilk;
                }
            }
            return "No topping has been added.";
        }
    }
}
