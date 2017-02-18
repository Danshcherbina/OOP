using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication1
{
    /// <summary>
    /// <para>Class, that represents a Product.</para>
    /// <para>Product can be either Toy, or a Produce.</para>
    /// <para>Has such virtual methods:</para>
    /// </summary>
    [Serializable]
    public class Product  : AbstractGoods, ProductThings                    // описание класса Товар
    {
        /// <summary>
        /// <para>ID to count nameless product. This field is unique for each product without a name.</para>
        /// </summary>
        //public static int Id { get; set; }
        /// <summary>
        /// <para>Product name.</para>
        /// </summary>
        /// <summary>
        /// <para>Product price.</para>
        /// </summary>
        Func<string, string> nowIsTheTime = beFine;
        static Action<string> message = delegate (string s) { Console.WriteLine(s); };
        /// <summary>
        /// <para>Default constructor, which fills name and price with default values.</para>
        /// </summary>
        public Product()
        {
            this.name = "product-1";
            price = 1;
        }
        /// <summary>
        /// <para>Constructor, which sets specific name and price to the product.</para>
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="price">Price</param>
        public Product(string name, int price)
        {
            this.price = price;
            this.name = name;
        }
        /// <summary>
        /// <para>Print all info about product</para>
        /// </summary>
        public virtual void printInf()
        {
            Console.Write("Name:{0}, price:{1}",this.name, this.price);
        }
        /// <summary>
        /// <para>Set a specific price</para>
        /// </summary>
        /// <param name="newPrice">new price</param>
        public void setPrice(int newPrice)
        {
            price = newPrice;
            if (price < 0)
            {
                throw new MyException(price, "Invalide price ");
            }
        }
        public int getPrice()
        {
            return price;
        }
        static string beFine(string s){
            Console.WriteLine(s + " is fine.");
            return "OK";
        }

        public void saleIt()
        {
            Console.WriteLine("Yey we sold one {0}!!", this.name);
        }

        public override void check()
        {
            Console.WriteLine("Product {0} checked.", this.name);
        }
        public override void stole()
        {
            Console.WriteLine("AAAAAA, {0} is stolen.", this.name);
        }
        public override void toBeChecked()
        {
            nowIsTheTime(name);
        }
    }

    /// <summary>
    ///   <para>Class, that represents a Product.</para>
    ///   <para>Product can be either Toy, or a Produce.</para>
    ///   <para>Has such virtual methods:</para>
    /// </summary>
    [Serializable]
    public class CopyOfProduct : AbstractGoods, ProductThings                    // описание класса Товар
    {
        /// <summary>
        /// <para>ID to count nameless product. This field is unique for each product without a name.</para>
        /// </summary>
        //public static int Id { get; set; }
        /// <summary>
        /// <para>CopyOfProduct name.</para>
        /// </summary>
        /// <summary>
        /// <para>CopyOfProduct price.</para>
        /// </summary>
        Func<string, string> nowIsTheTime = beFine;
        static Action<string> message = delegate (string s) { Console.WriteLine(s); };
        /// <summary>
        /// <para>Default constructor, which fills name and price with default values.</para>
        /// </summary>
        public CopyOfProduct()
        {
            this.name = "product-1";
            price = 1;
        }
        /// <summary>
        /// <para>Constructor, which sets specific name and price to the product.</para>
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="price">Price</param>
        public CopyOfProduct(string name, int price)
        {
            this.price = price;
            this.name = name;
        }
        /// <summary>
        /// <para>Print all info about product</para>
        /// </summary>
        public virtual void printInf()
        {
            Console.Write("Name:{0}, price:{1}", this.name, this.price);
        }
        /// <summary>
        /// <para>Set a specific price</para>
        /// </summary>
        /// <param name="newPrice">new price</param>
        public void setPrice(int newPrice)
        {
            price = newPrice;
            if (price < 0)
            {
                throw new MyException(price, "Invalide price ");
            }
        }
        public int getPrice()
        {
            return price;
        }
        static string beFine(string s)
        {
            Console.WriteLine(s + " is fine.");
            return "OK";
        }

        public void saleIt()
        {
            Console.WriteLine("Yey we sold one {0}!!", this.name);
        }

        public override void check()
        {
            Console.WriteLine("CopyOfProduct {0} checked.", this.name);
        }
        public override void stole()
        {
            Console.WriteLine("AAAAAA, {0} is stolen.", this.name);
        }
        public override void toBeChecked()
        {
            nowIsTheTime(name);
        }
    }
}