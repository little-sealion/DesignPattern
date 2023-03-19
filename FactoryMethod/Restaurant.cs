using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public abstract class Restaurant
    {
        public IBurger OrderBurger(string request)
        {

            var burger = CreateBurger();
            burger.Prepare();
            return burger;
        }
        public abstract IBurger CreateBurger();
    }
}