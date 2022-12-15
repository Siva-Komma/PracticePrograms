using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class Fact
    {
        public static void Factp(int num)
        {
            int facto = 1;
            Console.WriteLine("Enter the number" +num);
            for(int i=1; i<=num; i++)
            {
                facto = facto * i ;
            }
            Console.WriteLine("Factorial number: " + facto);

            Console.ReadLine();
        }
    }
}
