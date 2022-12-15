using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

           
            Console.WriteLine("1.Factriol\n 2.PrimeNumber\n 3.AmstrongNumber\n" +
                " 4.Swapping\n 5.Fahrenheit to celsius Conversion\n 6.Fibbonacci Series\n");
            int option = 0;
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    //Factorial
                    Fact.Factp(6);
                    Console.ReadLine();
                    break;
                case 2:
                    //Prime Number
                    Prime pn = new Prime();
                    pn.PrimeNum();
                    break;
                case 3:
                    //Amstrong Number
                    Amstrong am = new Amstrong();
                    am.AmstrongNum();
                    break;
                case 4:
                    //Swapping
                    Swapping s = new Swapping();
                    s.Swap();
                    break;
                case 5:
                    TempConversion.TempC();
                    break;
                case 6:
                    int num;
                    Console.WriteLine("Enter Number");
                    num = Convert.ToInt32(Console.ReadLine());
                    FibbonacciS.FibboS(num);

                    break;

                default:
                        {
                        Console.WriteLine("Enter Correct Number");
                        break;
                    }

              Console.ReadLine();
            }


        }
    }
}
