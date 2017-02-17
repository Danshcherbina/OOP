using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
     /*
     * По правилам чистого кода нужно избегать остроумия,
     *  по этому класс FakeProd был переименован в FoodModel.
     */

namespace ConsoleApplication1
{
    [Serializable]
    internal class FoodModel<T> where T : AbstractGoods
    {
        private T val;

        public FoodModel(T prod)
        {
            val = prod;
        }


        public T getValue()
        {
            return val;
        }
    }
}
