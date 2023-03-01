using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    interface ISampleInterface
    {
        void SampleMethod();
    }

    class ImplementationClass : ISampleInterface
    {
        void ISampleInterface.SampleMethod() {
            Console.WriteLine("Hello from ImplementationClass.");
        }
    }
    internal class Program
    {
        class Child
        {
            private int age;
            private string name;

            public Child()
            {
                name = "N/A";
            }
            public Child(int age, string name)
            {
                this.age = age;
                this.name = name;
            }
            public void PrintChild()
            {
                Console.WriteLine("{0}, {1} years old.",name,age);
            }
        }

        static void Main(string[] args)
        {
            Child child1 = new Child(21,"Jay");
            Child child2 = new Child(22,"Dev");
            Child child3 = new Child();

            Console.Write("Child1: ");
            child1.PrintChild();

            Console.Write("Child2: ");
            child2.PrintChild();

            Console.Write("Child3: ");
            child3.PrintChild();

            ISampleInterface obj = new ImplementationClass();
            obj.SampleMethod();

        }
    }
}
 