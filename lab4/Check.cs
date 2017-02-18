using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Check
    {
        public delegate void Insight(AbstractGoods Sender, Check Checks);
        public delegate void EventOfDay();
        public event EventOfDay Checking;
        public delegate void allert();
        allert message = delegate
        {
            Console.WriteLine("check time!");
        };
        public void IsItTime()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 76)
                {
                    message();

                    Checking?.Invoke();
                    break;
                }
            }
        }

        public Insight rightWay = (AbstractGoods Sender, Check Check) =>
        {

            Check.Checking += Sender.toBeChecked;
        };

    }

    class CopyOfCheck
    {
        public delegate void Insight(AbstractGoods Sender, CopyOfCheck Checks);
        public delegate void EventOfDay();
        public event EventOfDay Checking;
        public delegate void allert();
        allert message = delegate
        {
            Console.WriteLine("check time!");
        };
        public void IsItTime()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 76)
                {
                    message();

                    Checking?.Invoke();
                    break;
                }
            }
        }

        public Insight rightWay = (AbstractGoods Sender, CopyOfCheck CopyOfCheck) =>
        {

            CopyOfCheck.Checking += Sender.toBeChecked;
        };

    }
}
