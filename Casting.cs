﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;   //Int type
            long b = a;    //Long type                                     //Implicit
            byte z = Convert.ToByte(a);          //Explicit
            double p = a;                                  //Implicit
            int q = Convert.ToInt32(p);           //Explicit
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(z);
            Console.WriteLine(p);
            Console.WriteLine(q);
            char c = 'M';
            string s = Convert.ToString(c);    //Explicit
            Console.WriteLine(s);

        }
    }
}
