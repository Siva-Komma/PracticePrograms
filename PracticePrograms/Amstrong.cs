using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class Amstrong
    {
        public void AmstrongNum()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0, sum = 0, last=0;
            while(num!=0)
            {   
                rev = num % 10;
                last =(rev * rev * rev)+last;
                num = num / 10;
                
                //Console.WriteLine("Rev{0}" , last);
            }

            Console.WriteLine("Amstrong number is" +last);
        }
    }
}
