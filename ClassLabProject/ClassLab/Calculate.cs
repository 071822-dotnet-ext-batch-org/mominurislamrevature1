using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLab
{
   // Compile Time Polymorphism (overloading)
    public class Calculate
    {
        public void AddNumbers(int number1, int number2)
       {
          Console.WriteLine("a + b = {0}", number1 + number2);
       }
       public void AddNumbers(int number1, int number2, int number3)
       {
          Console.WriteLine("a + b + c = {0}", number1+ number2 + number3);
       }
    }
}