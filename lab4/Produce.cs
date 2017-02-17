using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [Serializable]
    public class Produce : Product, ProductThings                // Описание класса Продукт
    {
        /// <summary>
        /// <para>Total amount of products.</para>
        /// </summary>
        private static int ProdCount { get; set; }
        /// <summary>
        /// <para>Day when produce was packed.</para>
        /// </summary>
        protected string packDate;
        /// <summary>
        /// <para>Default constructor, which fills name, packDate and price with default values.</para>
        /// </summary>
        public Produce()
            : base()
        {
            ProdCount += 1;
            this.packDate ="00-00-00";
        }
        /// <summary>
        /// <para>Constructor, which sets specific name, packDate and price to the product.</para>
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="price">Price</param>
        /// <param name="packYear">packYear</param>
        public Produce(string name, int price, string packYear)
            : base(name, price)
        {
            ProdCount += 1;
            this.packDate = packYear;
        }

        public override void printInf()
        {
            base.printInf();
            Console.WriteLine(", pack date:{0}",this.packDate);
        }
        /// <summary>
        /// <para>Get produce name</para>
        /// </summary>
        ///  <returns>Produce name</returns>
        public string getProduceName()
        {
            return this.name;
        }
        /// <summary>
        /// <para>Get amount of produces</para>
        /// </summary>
        ///  <returns>Produce amount</returns>
        public int getProdAmount()
        {
            return ProdCount;
        }
    }
}
