using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class Prime
    {
        public int num;
        public void Primep()
        {
            int num=0;
            Console.WriteLine("Enter number");
            int p = num / 2;
            for(int i=2; i<=p; i++)
            {
                    if(num%i!=0)
                     {
                       Console.WriteLine("Not Prime Number");
                     } 
                    else
                     {
                    Console.WriteLine("Prime Number");
                      } 
                               
            }
            Console.ReadLine();
        }
    }
}
