using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public class VeggieBurgerRestaurant : Restaurant
    {
        public override IBurger CreateBurger()
        {
            return new VeggieBurger();
        }
    }
}