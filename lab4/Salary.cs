using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using ConsoleApplication1;
namespace ConsoleApplication1
{
    enum Days { Mon = 1, Tue, Wed, Thu, Fri, Sat, Sun };
    [Serializable]
    class Salary
    {
        private string name;
        private int count;
        private int currentDay;
        List<Product> Products = new List<Product>();

        private List<FakeProd<Product>> Inside = new List<FakeProd<Product>>();

        public Salary(string _namy, int day)
        {
            this.name = _namy;
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



        public bool addFakeProd(FakeProd<Product> product)
        {
            if (count < 450)
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
            if (count < 450)
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


        private Product GetProdsByName(string Name)
        {
            for (int i = 0; i < count; i++)
            {
                if (Products[i].name == Name)
                {
                    return Products[i];
                }
            }

            Console.WriteLine("Where you dug it?");
            return null;
        }
    }

    [Serializable]
    class CopyOfSalary
    {
        private string name;
        private int count;
        private int currentDay;
        List<Product> Products = new List<Product>();

        private List<FakeProd<Product>> Inside = new List<FakeProd<Product>>();

        public CopyOfSalary(string _namy, int day)
        {
            this.name = _namy;
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



        public bool addFakeProd(FakeProd<Product> product)
        {
            if (count < 450)
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
            if (count < 450)
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


        private Product GetProdsByName(string Name)
        {
            for (int i = 0; i < count; i++)
            {
                if (Products[i].name == Name)
                {
                    return Products[i];
                }
            }

            Console.WriteLine("Where you dug it?");
            return null;
        }
    }
}
