using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza___Poject
{
    internal class PizzaOrder
    {
        public string Size { get; set; }
        public string Crust { get; set; }
        public List<string> Toppings { get; set; }


        public decimal GetTotalPrice()
        {
            decimal price = 0;

            switch (Size)
            {
                case "Small": price += 10;break;
                case "Medium": price += 10;break;
                case "Larg": price += 10;break;
            }

            if (Crust == "Thick Crust")
                price += 5;

            price += Toppings.Count * 5;

            return price;
        }
    }
}
