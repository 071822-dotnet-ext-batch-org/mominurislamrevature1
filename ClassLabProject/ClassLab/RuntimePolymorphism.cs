using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLab
{

     public class Iphone
    {
       public virtual void GetInfo()
       {
          Console.WriteLine("This is Iphone");
       }
    }


    public class Samsung : Iphone
    {
       public override void GetInfo()
       {
          Console.WriteLine("This is Samsung Phone");
       }
    }

    public class RuntimePolymorphism
    {
         
    }
}