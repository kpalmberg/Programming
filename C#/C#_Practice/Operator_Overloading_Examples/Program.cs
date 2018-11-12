using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Object 1: ");
            TestObject o1 = new TestObject(2);
            o1.Display();

            Console.Write("\nObject 2: ");
            TestObject o2 = new TestObject(3);
            o2.Display();

            //TestObject o3 = o1 + o2;
            //o3.Display();

            Console.WriteLine("\nTesting Object1 > Object2.");

            if((o1 > o2) == true)
            {
                Console.WriteLine("True!\n");
            }
            else
            {
                Console.WriteLine("Object 1 has value " + o1.ID + " which is not greater than " + o2.ID + ", false.");
            }

            Console.WriteLine("\nTesting Object1 < Object2.");

            if ((o1 < o2) == true)
            {
                Console.WriteLine("True!\n");
            }
            else
            {
                Console.WriteLine("Object 1 has value " + o1.ID + " which is not less than " + o2.ID + ", false.");
            }

        }
    }
}
