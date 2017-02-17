using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using ConsoleApplication1;

/**
* На этом участке кода было применено горизонтальное и вертикальное форматирование согласно правилам чистого кода,
* что бы повысить его читабельность.
* */

namespace ConsoleApplication1
{
    enum Days { Mon = 1, Tue, Wed, Thu, Fri, Sat, Sun };
    [Serializable]
    class Salary
    {
        private const int maxcountOfProducts = 10;
        private string name;
        private int count;
        private int currentDay;
        List<Product> Products = new List<Product>();

        private List<FoodModel<Product>> Inside = new List<FoodModel<Product>>();
        /**
         * По правилам чистого кода имена должны соолветсвовать намерениям програмиста,
         * по этому переменная string _namy = 0; которая отвечала за имя коллекции переименована.
         * */
        public Salary(string _name, int day)
        {
            this.name = _name;
            count = 0;
            currentDay = Math.Abs(day % 8);
        }

        public void showDay()
        {
            Console.WriteLine("Current day = " + currentDay);
        }

        public void changeDay()
        {
            currentDay = Math.Abs(currentDay++ % 8);
        }

        public bool work()
        {
            if (currentDay == (int)Days.Sun || currentDay == (int)Days.Sat)
            {

                Console.WriteLine("Sorry, we closed for weekend!");
                return false;

            }
            else
            {
                Console.WriteLine("Welcome!");
                return true;
            }

        }


        /**
         * Так как названия классов должны представлять собой глагольные словосочитания,
         * то метод newFoodModel был переименован в addFoodModel.
         **/
        public bool addFoodModel(FoodModel<Product> product)
        {
            if (count < maxcountOfProducts)
            {
                Inside.Add(product);
                count++;
                return true;
            }
            else
            {
                Console.WriteLine("Need place!");
                return false;
            }
        }




        public bool addProd(Product prod)
        {
            /**
            * Согласно правилам чистого кода непонятное число 450 было заменено константой.
             * */
            if (count < maxcountOfProducts)
            {
                Products.Add(prod);
                count++;
                return true;
            }
            else
            {
                Console.WriteLine("Need place!");
                return false;
            }

        }

        //По правилу рефакторинга про дублирование кода две предыдущие функции с почти аналогичным кодом были обьеденены в одну.

        public bool univesalAdd(object obj)
        {
            Console.WriteLine("Type = " + obj.GetType());

            if (count < 450)
            {

                if (obj is Product)
                {
                    Products.Add((Product)obj);
                }
                else
                {

                    if (obj is FoodModel<Product>)
                    {
                        Inside.Add((FoodModel<Product>)obj);

                    }
                    else
                    {
                        return false;
                    }
                }
                count++;
                return true;
            }
            else
            {
                Console.WriteLine("Need place!");
                return false;
            }

        }

        public void showProducts()
        {

            foreach (Product prod in Products)
            {

                if (prod != null)
                {
                    prod.printInf();
                }
            }

        }
        
        public void sortProdsByPrice()
        {
            Products.Sort();
        }

        /**
        * Согласно правилам чистого кода функция или метод не должны делать никаких побочных действий.
        * Потому из функции был убран вывод на экран:
        *  Console.WriteLine("Where you dug it?");
        * 
        * */
        private Product GetProdsByName(string Name)
        {
            for (int i = 0; i < count; i++)
            {
                if (Products[i].name == Name)
                {
                    return Products[i];
                }
            }
            return null;
        }
    }
}
