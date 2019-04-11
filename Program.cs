using System;

using ClassLibrary1;

namespace Clearmeasure
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Console.WriteLine("Hello World!");
               for (int i=1;i<=100;i++)
               {
                   //check the no divisible by 3 then print Fizz or check the no divisible by 5 then print Buzz
                   if ((i % 3 ) == 0)
                       Console.WriteLine("Fizz");
                   if ((i % 5) == 0)
                       Console.WriteLine("Buzz");

                   if ((i % 3 != 0) && (i % 5 != 0))
                       Console.WriteLine(i);



               }
               Console.ReadKey();*/

            ClassLibrary1.Class1 c=new ClassLibrary1.Class1();
            c.Main();
        }
    }
}
