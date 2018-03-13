using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
  

    class Constructors   // Here Classname and Method name are same
    {
        int a, b;
        public Constructors()   //default contructor
        {
            a = 1000;
            b = 1500;
        }

        public static void Main()
        {
            Constructors obj = new Constructors(); //an object is created , constructor is called
            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);

        }
    }

    // Copy Constructors
    class employee
    {
        private string name;
        private int age;
        public employee(employee emp)   // declaring Copy constructor.
        {
            name = emp.name;
            age = emp.age;
        }
        public employee(string name, int age)  // Instance constructor.
        {
            this.name = name;
            this.age = age;
        }
        public string Details     // Get deatils of employee
        {
            get
            {
                return " The age of " + name + " is " + age.ToString();
            }
        }
    }
    class empdetail
    {
        static void Main()
        {
            employee emp1 = new employee("mam", 21);  // Create a  object.
            employee emp2 = new employee(emp1);          // here is emp1 details is copied to emp2.
            Console.WriteLine(emp2.Details);

        }
    }
    //Parameterized Constructor
    class paraconstrctor
    {
        public int m, n;

        public paraconstrctor(int x, int y)  // decalaring Paremetrized Constructor with int x,y parameter
        {
            m = x;
            n = y;
        }
    }
    class MainClass
    {
        static void Main()
        {
            paraconstrctor v = new paraconstrctor(1, 2);    // Creating object of Parameterized Constructor and int values 
           
            Console.WriteLine("value of a=" + v.m);
            Console.WriteLine("value of b=" + v.n);

        }
    }
}
