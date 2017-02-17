using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;
namespace ConsoleApplication1
{
    class Delights : IEnumerable, IEnumerator, IDisposable
    {
        private const int countOfProducts = 10;
        private int currentCountOfProducts = 0;
        private Product[] delights = new Product[countOfProducts];
        private int productsIndex = -1;


        public Product this[string Name]
        {
            get
            {
                for (int i = 0; i < countOfProducts; i++)
                {
                    if (delights[i].name == Name)
                    {
                        return delights[i];
                    }
                }

                Console.WriteLine("Where you dug it?");
                return null;
            }
        }



        public bool addProd(Product prod)
        {
            if (currentCountOfProducts < 10)
            {
                delights[currentCountOfProducts] = prod;
                currentCountOfProducts++;
                return true;
            }
            else
            {
                Console.WriteLine("No more!");
                return false;
            }


        }


        public IEnumerator GetEnumerator()
        {
            return this;
        }




        public bool MoveNext()
        {
            if (productsIndex == delights.Length - 1 || delights[productsIndex + 1] == null)
            {
                Reset();
                return false;
            }

            productsIndex++;
            return true;
        }




        public void Reset()
        {
            productsIndex = -1;
        }

        public object Current
        {
            get
            {
                return delights[productsIndex];
            }
        }
        public void Dispose()
        {
            foreach (Product product in delights)
            {
                if (product != null)
                {
                    product.Dispose();
                }

            }
        }

        ~Delights()
        {
            Dispose();
        }
    }
}
