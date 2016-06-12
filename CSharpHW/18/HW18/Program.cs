using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileOperator op = new MobileOperator();
            MobileAccount acc1 = new MobileAccount("+380636419975");            
            MobileAccount acc2 = new MobileAccount("+380933994597");
            MobileAccount acc3 = new MobileAccount("+380734558990");
            acc1.MakeACall("+380933994597");
            acc2.MakeACall("+380734558990");
            acc3.MakeACall("+380636419975");
            acc1.SendMessage("+380734558990", "Hello!");
            Console.ReadKey();
        }
    }
}
