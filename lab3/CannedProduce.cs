using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [Serializable]
    public class СannedProduce : Produce, ProductThings        //описание класса консервы
    {
        /// <summary>
        /// <para>Shelf life.</para>
        /// </summary>
        private double weight;
        /// <summary>
        /// <para>Default constructor, which fills name, packDate and price with default values.</para>
        /// </summary>
        public СannedProduce()
            : base()
        {
            this.weight = 0.0;
        }
        /// <summary>
        /// <para>Constructor, which sets specific name, packDate and price to the product.</para>
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="price">Price</param>
        /// <param name="packYear">packYear</param>
        /// <param name="weight">weight</param>
        public СannedProduce(string name, int price, string packYear, double weight)
            : base(name, price, packYear)
        {
            this.weight = weight;
        }
        public override void printInf()
        {
            base.printInf();
            Console.WriteLine("weight(in kg):{0}", this.weight);
        }
        /// <summary>
        /// <para>Get produces weight</para>
        /// </summary>
        ///  <returns>Produce weight</returns>
        public double getWeight()
        {
            return this.weight;
        }
    }
}
