using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3_Polymorphism
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Bird myBrid = new Bird();
            Bird myDuck = new Duck();
            Duck myDuck1 = new Duck();
            myBrid.Voice();
            myDuck.Voice();
            myDuck1.Voice();

        }
    }
    public class Bird
    {
        //Brid class voice method prints "Turr Turr".
        public void Voice()
        {
            Console.WriteLine("Turr Turr");
        }
    }
    public class Duck : Bird
    {
        //Duck class voice method prints "Quack Quack".
        public void Voice()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
