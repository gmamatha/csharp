using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main()
        {
            int a = 100;
            int b;
            b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            // This is For Assignment Operator
            a += 10; /* a = a + 10; */
            Console.WriteLine(a); //110


            // This is For Airthmetic Opeator
            int x = 50;
            int y = 50;
            int Res;
            Res = x + y;
            Console.Write("\n The Addition of two numbers is: " + Res);
            Res = a - b;
            Console.Write("\n The Subtraction of two numbers is: " + Res);

            // Comparision Operator

            int m1 = 50, m2 = 100;

            if (m1 > m2)
            {
                Console.WriteLine("x is greater than y", m1, m2);
            }

            else if (m2 > m1)
            {
                Console.WriteLine("y is greater than x", m1, m2);
            }
            else
            {
                Console.WriteLine("x and y are equal", m1, m2);
            }

            //Increment Operators
            int xxx = 1000;

            Console.WriteLine("incrementing values are");

            xxx++;

            Console.WriteLine(" first increment is " + xxx);


            --xxx;

            Console.WriteLine(" first decrement is " + xxx);

            // This is For Relational Operators
            long s = 1000, u = 2000;

            bool b1 = (s == u);
            bool b2 = (s != u);
            bool b3 = (s < u);
            bool b4 = (s > u);
            bool b5 = (s <= u);
            bool b6 = (s >= u);
            Console.WriteLine(b1); /*false*/
            Console.WriteLine(b2); //true
            Console.WriteLine(b3); //true
            Console.WriteLine(b4); //false
            Console.WriteLine(b5); //true
            Console.WriteLine(b6); //false  

        }
    }
}
