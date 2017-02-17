namespace ConsoleApplication1
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public static class Extension
    {
        static int someCount(this Delights salary, string name)
        {
            int counter = 0;

            foreach (Product product in salary)
            {

                if (product.name == name)
                {
                    counter++;


                }

            }

            Console.WriteLine("There are " + counter + " " + name + " products in salary.");

            return counter;
        }
    }
}
