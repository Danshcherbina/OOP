using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;
namespace ConsoleApplication1
{
    /// <summary>
    /// <para>Class, that represents a Product.</para>
    /// <para>Product can be either Toy, or a Produce.</para>
    /// <para>Has such virtual methods:</para>
    /// </summary>
    [Serializable]
    public class Product  : AbstractGoods, ProductThings, IComparable<Product>, IDisposable                // описание класса Товар
    {
        /**
        * Тут стоял старый коментарий который указывал на переменные, которые теперь объявлены в AbstractGoods.cs 
        * Согласно правилам чистого кода старые комментарии должны удаляться или обновляться.
        * */
        
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
        public int CompareTo(Product obj)
        {
            return this.price.CompareTo(obj.price);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}