using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class Swapping
    {
        public void Swap()
        {
            int var = 0, var1 = 0, var2 = 0;
          
            Console.WriteLine("Enter a value1");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value2");
            var2 = Convert.ToInt32(Console.ReadLine());

            var = var1;
            var1 = var2;
            var2 = var;

            Console.WriteLine("var1 {0} var2 {1}",var1,var2);
            Console.ReadLine();

        }
    }
}
