using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// <para>Class, that represents a Product.</para>
    /// <para>Product can be either Toy, or a Produce.</para>
    /// <para>Has such virtual methods:</para>
    /// </summary>
    public class Product                      // описание класса Товар
    {
        /// <summary>
        /// <para>ID to count nameless product. This field is unique for each product without a name.</para>
        /// </summary>
        public static int Id { get; set; }
        /// <summary>
        /// <para>Product name.</para>
        /// </summary>
        protected string Name { get; set; }
        /// <summary>
        /// <para>Product price.</para>
        /// </summary>
        private double price;
        protected double Price {
            get
            {
                return this.price;
            }
            set
            {
                this.price = (price > 0.0) ? 0 : value;
            }
        }
        /// <summary>
        /// <para>Default constructor, which fills name and price with default values.</para>
        /// </summary>
        public Product()
        {
            this.Name = "product-" + (++Id).ToString();
            this.Price = 0;
        }
        /// <summary>
        /// <para>Constructor, which sets specific name and price to the product.</para>
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="price">Price</param>
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        /// <summary>
        /// <para>Print all info about product</para>
        /// </summary>
        public virtual void PrintInf()
        {
            Console.Write("Name:{0}, price:{1}",this.Name, this.Price);
        }
        /// <summary>
        /// <para>Set a specific price</para>
        /// </summary>
        /// <param name="newPrice">new price</param>
        public void setPrice(double newPrice)
        {
            this.Price = newPrice;
        }
    }
}