using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ленивый класс
//Так как существование класса не окупается выполняемыми им функциями, он должен быть ликвидирован.
/*
namespace ConsoleApplication1
{
    class ExpToy : Toys, ToyThings, ProductThings
    {
        private static int prices = 1200;
        private ExpToy(string name, int price, string country)
           : base(name, price, country)
        {
            this.name = "Rare toy "+name;
        }
        public static Toys crtExpToy(string name, int money, string country)
        {
            if (money > prices)
            {
                var ExpToy = new ExpToy(name, money, country);
                return ExpToy;
            }
            else
            {
                Console.WriteLine("fail of creation:not enough gold");  
            }
            return new Toys(name, money, country);
        }

    }
}
*/