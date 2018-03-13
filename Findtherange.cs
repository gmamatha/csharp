using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Findtherange
    {
        static void Main(string[] args)
        {
            //Here i calculated the Max and min range for int , float, decimal,single, Double
            Console.WriteLine("The Maximum Range of the Decimal Data Type is : {0} ", int.MaxValue);
            Console.WriteLine("The Maximum Range of the Decimal Data Type is : {0} ", float.MaxValue);
            Console.WriteLine("The Maximum Range of the Decimal Data Type is : {0} ", Decimal.MaxValue);
            Console.WriteLine("The Maximum Range of the Float Data Type is : {0} ", Single.MaxValue);
            Console.WriteLine("The Maximum Range of the Decimal Data Type is : {0} ", Double.MaxValue);
            Console.WriteLine("The Minimum Range of the Decimal Data Type is : {0} ", int.MinValue);
            Console.WriteLine("The Minimum Range of the Decimal Data Type is : {0} ", float.MinValue);
            Console.WriteLine("The Minimum Range of the Decimal Data Type is : {0} ", Decimal.MinValue);
            Console.WriteLine("The Minimum Range of the Float Data Type is : {0} ", Single.MinValue);
            Console.WriteLine("The Minimum Range of the Decimal Data Type is : {0} ", Double.MinValue);
        }
    }
}
