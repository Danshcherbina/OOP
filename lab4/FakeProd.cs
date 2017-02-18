using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    [Serializable]
    internal class FakeProd<T> where T : AbstractGoods
    {
        private T val;

        public FakeProd(T prod)
        {
            val = prod;
        }


        public T getValue()
        {
            return val;
        }
    }

    [Serializable]
    internal class CopyOfFakeProd<T> where T : AbstractGoods
    {
        private T val;

        public CopyOfFakeProd(T prod)
        {
            val = prod;
        }


        public T getValue()
        {
            return val;
        }
    }
}
