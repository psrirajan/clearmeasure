using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Class1
    {
        public void Main()
        {
            int n;
            n = 0;
            Console.WriteLine("Enter any number for Upper Boundary");
            n=Int32.Parse(Console.ReadLine());
            Console.ReadKey();  
            
            for (int i = 1; i <= n; i++)
            {
                //check the no divisible by 3 then print Fizz or check the no divisible by 5 then print Buzz
                if ((i % 3) == 0)
                    Console.WriteLine("Fizz");
                if ((i % 5) == 0)
                    Console.WriteLine("Buzz");

                if ((i % 3 != 0) && (i % 5 != 0))
                    Console.WriteLine(i);



            }
            Console.ReadKey();
        }
    }
}
