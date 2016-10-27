using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Toys : Product           //описание класса Игрушка
    {
        /// <summary>
        /// <para>User age</para>
        /// </summary>
        static readonly string userAge;
        /// <summary>
        /// <para>Toy counter</para>
        /// </summary>
        private static int ToyCount { get; set; }
        /// <summary>
        /// <para>toy country</para>
        /// </summary>
        private string country;
        /// <summary>
        /// <para>static constructor</para>
        /// </summary>
        static Toys()
        {
            userAge = "for 6 years and older";
        }
        /// <summary>
        /// <para>Default constructor, which fills name, packDate and price with default values.</para>
        /// </summary>
        public Toys()
            : base()
        {
            ToyCount += 1;
            this.country = "not confirmed";
        }
        /// <summary>
        /// <para>Constructor, which sets specific name, packDate and price to the product.</para>
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="price">Price</param>
        /// <param name="country">country</param>
        public Toys(string name, double price, string country)
            : base(name, price)
        {
            ToyCount += 1;
            this.country = country;
        }
        public override void PrintInf()
        {
            base.PrintInf();
            Console.WriteLine(", country:{0}",this.country);
        }
        /// <summary>
        /// <para>Get toy name</para>
        /// </summary>
        ///  <returns>toy name</returns>
        public string getToyName()
        {
            return this.Name;
        }
        /// <summary>
        /// <para>Get country of toy</para>
        /// </summary>
        ///  <returns>toy country</returns>
        public string getToyCountry()
        {
            return this.country;
        }
        /// <summary>
        /// <para>Get amount of toys</para>
        /// </summary>
        ///  <returns>toy amount</returns>
        public int getToyAmount()
        {
            return ToyCount;
        }
        /// <summary>
        /// <para>Get user age of toys</para>
        /// </summary>
        ///  <returns>toy user age</returns>
        public string getToyUserAge()
        {
            return userAge;
        }
    }
}
