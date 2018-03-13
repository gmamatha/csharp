using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Looping
    {
    
     
            static void Main()
        {

	        int Even=1000;

                //If Condition
 	        if(Even%2==0)
	        Console.WriteLine("Even Num");
	        if(Even%2!=0)
	        Console.WriteLine("Odd Num");
           //If Else Condition
            int n = 16;
            if (n <= 9)
                Console.WriteLine("Single digit");
            else
                Console.WriteLine("Not single digit");

                // Switch Condition
            char x = 'g';
            switch (x)
            {
                case 'w': Console.WriteLine("w->white");
                    break;
                case 'b': Console.WriteLine("b->black");
                    break;
                case 'r': Console.WriteLine("r->Red");
                    break;
                case 'g': Console.WriteLine("g->Green");
                    break;
                default: Console.WriteLine("No color");
                    break;
            }
                 
        }
    }
}
