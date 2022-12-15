using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    class FibbonacciS
    {
       public  static int val1 = 0, val2 = 1;
        public static int FibboS(int num)
        {
            int val = 0;
            //Console.WriteLine("the values"+val1, +val2);
            Console.Write(val1 + " " + val2 + " ");
            for (int i=2; i<=num; i++)
            {
                val = val1 + val2;
                Console.WriteLine(val+" ");
                val1= val2;
                val2= val;
             //   Console.WriteLine("Values" + val);
            }
           // Console.WriteLine("Fibbo series " + val);
            //FibboS(num - 1);
            Console.ReadLine();
           return val;

        }
    }
}