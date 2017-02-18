using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [Serializable]
    public class MilkProduce : Produce, ProductThings        //описание класса Молочный продукт
    {
        /// <summary>
        /// <para>Shelf life.</para>
        /// </summary>
        private int shelfL;
        /// <summary>
        /// <para>Default constructor, which fills name, packDate and price with default values.</para>
        /// </summary>
        public MilkProduce()
            : base()
        {
            this.shelfL = 0;
        }
        /// <summary>
        /// <para>Constructor, which sets specific name, packDate and price to the product.</para>
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="price">Price</param>
        /// <param name="packYear">packYear</param>
        /// <param name="shelfL">shelf life</param>
        public MilkProduce(string name, int price, string packYear, int shelfL)
            : base(name, price, packYear)
        {
            this.shelfL = shelfL;
        }
        public override void printInf()
        {
            base.printInf();
            Console.WriteLine("shelf life(in days):{0}", this.shelfL);
        }
        /// <summary>
        /// <para>Get produces shelf life</para>
        /// </summary>
        ///  <returns>Produce shelf life</returns>
        public int getShelfLife()
        {
            return this.shelfL;
        }
    }

    [Serializable]
    public class CopyOfMilkProduce : Produce, ProductThings        //описание класса Молочный продукт
    {
        /// <summary>
        /// <para>Shelf life.</para>
        /// </summary>
        private int shelfL;
        /// <summary>
        /// <para>Default constructor, which fills name, packDate and price with default values.</para>
        /// </summary>
        public CopyOfMilkProduce()
            : base()
        {
            this.shelfL = 0;
        }
        /// <summary>
        /// <para>Constructor, which sets specific name, packDate and price to the product.</para>
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="price">Price</param>
        /// <param name="packYear">packYear</param>
        /// <param name="shelfL">shelf life</param>
        public CopyOfMilkProduce(string name, int price, string packYear, int shelfL)
            : base(name, price, packYear)
        {
            this.shelfL = shelfL;
        }
        public override void printInf()
        {
            base.printInf();
            Console.WriteLine("shelf life(in days):{0}", this.shelfL);
        }
        /// <summary>
        /// <para>Get produces shelf life</para>
        /// </summary>
        ///  <returns>Produce shelf life</returns>
        public int getShelfLife()
        {
            return this.shelfL;
        }
    }
}
