using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14_Q3
{
    static internal class Program
    {
        interface IName
        {
            void method();
        }

        public class ClassOne : IName
        {
            public void method()
            {
                Console.WriteLine("This is class one");
            }
        }

        public class ClassTwo : IName
        {
            public void method()
            {
                Console.WriteLine("This is probably class two");
            }
        }

        public static void MyMethod(object myObject)
        {
            // use the interface to call the common method name
            IName myO;

            myO = (IName)myObject;

            myO.method();
        }

        static void Main(string[] args)
        {
            // create objects of both classes
            ClassOne obj1 = new ClassOne();

            ClassTwo obj2 = new ClassTwo();

            // call MyMethod with each object
            MyMethod(obj1);
            MyMethod(obj2);
        }
    }
}
