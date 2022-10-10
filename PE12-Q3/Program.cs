using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PE12_Q3
{
    internal class Program
    {
        public class MyClass
        {
            private string myString = "myString";

            public string MyString;

            public virtual string GetString()
            {
                {
                    return myString;
                }
            }
        }

        public class MyDerivedClass: MyClass
        {
            public override string GetString()
            {
                return MyString + base.GetString();
            }
        }

        static void Main(string[] args)
        {
            MyDerivedClass myDClass = new MyDerivedClass();
            Console.WriteLine(myDClass.GetString());
        }
    }
}
