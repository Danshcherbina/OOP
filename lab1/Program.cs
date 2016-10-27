using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Toys = new Toys("Batman", 121.99 ,"USA");
            Toys.PrintInf();
            var Toys1 = new Toys();
            Toys1.PrintInf();
            Console.WriteLine("number of toys:{0}",Toys1.getToyAmount());
            var Milk = new MilkProduce();
            var Canned = new СannedProduce();
            Milk.PrintInf();
            Canned.PrintInf();
            Milk.setPrice(12.58);
            Milk.PrintInf();
            Console.WriteLine("number of produces:{0}", Canned.getProdAmount());
            Console.WriteLine("user age of {0}: {1}",Toys.getToyName(), Toys.getToyUserAge());
            Console.WriteLine("user age of {0}:{1}", Toys1.getToyName(), Toys1.getToyUserAge());
            var Product = new Product();
            Product.PrintInf();
            Console.ReadKey();
        }
    }
}
