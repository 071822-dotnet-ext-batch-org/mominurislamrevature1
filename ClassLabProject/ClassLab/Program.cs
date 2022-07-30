using System;

namespace ClassLab
{
    class Program 
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Compile Time Polymorphism");
          Console.ReadLine();
          Calculate c = new Calculate();
          c.AddNumbers(1, 2);
          c.AddNumbers(1, 2, 3);

          Console.WriteLine("Run Time Polymorphism");
          Console.ReadLine();
          Iphone d = new Iphone();
          d.GetInfo();
          Samsung b = new Samsung();
          b.GetInfo();
          Console.WriteLine("\nPress Enter Key to Exit..");
          Console.ReadLine();
        }
    }
}
