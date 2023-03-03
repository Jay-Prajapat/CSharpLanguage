using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3_Polymorphism
{
    internal class Program
    {
        public class Brid
        {
            //Brid class voice method prints "Turr Turr".
            public void Voice()
            {
                Console.WriteLine("Turr Turr");
            }
        }
        public class Duck : Brid
        {
            //Duck class voice method prints "Quack Quack".
            public void Voice()
            {
                Console.WriteLine("Quack Quack");
            }
        }
        static void Main(string[] args)
        {
            Brid myBrid = new Brid();
            Duck myDuck = new Duck();
            myBrid.Voice();
            myDuck.Voice();
        }
    }
}
