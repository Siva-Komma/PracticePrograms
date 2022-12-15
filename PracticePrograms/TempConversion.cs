using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class TempConversion
    {
       public static double TempC()
        {
            Console.WriteLine("Fahrenheit to Celsius Conversion");
            int FahrenT = 0;
            FahrenT = Convert.ToInt32(Console.ReadLine());
            double temp = 0;
            temp = ((FahrenT - 32) * (.5556));

            Console.WriteLine("Celsius Tempeturature"+temp);
            

            Console.WriteLine("Celsius to Fahrenheit Conversion");
            int Celsius = 0;
            Celsius = Convert.ToInt32(Console.ReadLine());
            temp = ((Celsius*1.8)+32);

            Console.WriteLine("Fahrenheit Tempeturature" + temp);
            Console.ReadLine();

            return temp;
     
           


        }
    }
}
