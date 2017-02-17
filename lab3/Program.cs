using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using ConsoleApplication1;

    class Program
    {
        static void Main(string[] args)
        {
            var Toys = new Product("Batman", 121);
            Toys.printInf();
            var Toys1 = new Product("hz", 240);
            Toys1.printInf();
            var Rare = new Product("Mishka",1300);
            Check CheckT = new Check();
            CheckT.rightWay(Rare, CheckT);
            CheckT.IsItTime();
            /**
            *Тут был закомментированый код
            * try
              {
                  Rare.setPrice(-1);
              }
              catch (MyException exeption)
              {
                  Console.WriteLine("Error : " + exeption.Message + "(" + exeption.PriceV + ")");
              }
            *который использовался до того, чтоб создать и обработать исключительную ситуацию
            *Согласно правилам чистого кода он должен быть удален.
            */
            Salary atb = new Salary("ATB", 6);
            atb.addProd(Toys);
            atb.addProd(Toys1);
            atb.addProd(Rare);
            Product Joy = new Product("Joy", 23);

            FoodModel<Product> Kinder = new FoodModel<Product>(Joy);
            atb.addFoodModel(Kinder);
            atb.showProducts();
            Delights delights = new Delights();
            delights.addProd(new Product("Nutella", 82));
            delights.addProd(new Product("Meat", 54));
            delights.addProd(new Product("Big Kinder", 99));
            foreach (Product prod in delights)
            {
                prod.printInf();
            }
            Console.WriteLine(" ");
            Console.WriteLine("All products:");
            atb.showProducts();
            Console.WriteLine(" ");
            /*
            Console.WriteLine("Sort products by price:");
            atb.sortProdsByPrice();
            */
            atb.work();
            atb.showDay();
            Console.WriteLine(" ");
            Console.WriteLine("Object for binary serialization");
            Product Volunteer2 = new Product("Moroz", 25);
            
            BinaryFormatter formatter = new BinaryFormatter();

            XmlSerializer formatter1 = new XmlSerializer(typeof(Product));


            using (FileStream fs = new FileStream("Products.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, atb);

                Console.WriteLine("Object serialized.");
            }

            using (FileStream fs = new FileStream("Prod.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Volunteer2);

                Console.WriteLine("Object serialized");
            }

            using (FileStream fs = new FileStream("Prod.xml", FileMode.OpenOrCreate))
            {
                Product surv = (Product)formatter.Deserialize(fs);

                Console.WriteLine("Object 2 deserialized");
                surv.printInf();

            }

            using (FileStream fs = new FileStream("Products.dat", FileMode.OpenOrCreate))
            {

                Salary lastOfUs = (Salary)formatter.Deserialize(fs);
                Console.WriteLine(" ");
                Console.WriteLine("Last servants:");
                lastOfUs.showProducts();
            }
            
            WeakReference wr = new WeakReference(delights);
            delights = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            if (wr.Target != null)
            {
                Console.WriteLine("Not Collected");
            }
            else
            {
                Console.WriteLine("Collected");
            }
            Console.ReadKey();
         }
    }

