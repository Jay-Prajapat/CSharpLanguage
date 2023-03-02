using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegates
{
    public delegate void MathDelegate(int num1, int num2); 
    internal class Program
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine($"Addition of {x} and {y} is {x+y}");
        }

        public static void Sub(int x, int y)
        {
            Console.WriteLine($"Subtraction of {x} and {y} is {x - y}");
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x} and {y} is {x * y}");

        }
        public void Div(int x, int y)
        {
            Console.WriteLine($"Division of {x} and {y} is {x / y}");

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            MathDelegate del1 = new MathDelegate(Add);
            MathDelegate del2= new MathDelegate(Program.Sub);
            MathDelegate del3 = new MathDelegate(p.Mul);
            MathDelegate del4 = new MathDelegate(p.Div);

            MathDelegate del5 = del1 + del2 + del3 + del4;
            Delegate[] InvocationList = del5.GetInvocationList();
            Console.WriteLine("Invocation List: ");
            foreach(var item in InvocationList)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
            Console.WriteLine("Invoking multicast delegates");
            del5.Invoke(20, 5);
            Console.WriteLine("After removing one delegate.");
            del5 -= del2;
            del5(22, 7);
        }
    }
}
