using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    class Prime
    {
        public void PrimeNum()
        {
            Console.WriteLine("Enetr number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
           for(int i=1; i<=num;i++)
            {
                if(num%i==0)
                {
                    count = count + 1;
                }
            }

           if(count==2)
            {
                Console.WriteLine("Is a prime number");
            }
            else
            {
                Console.WriteLine("Not a prime number");
            }
        }


    }   
}

