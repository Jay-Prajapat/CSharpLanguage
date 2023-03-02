using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userResponse = Console.ReadLine();
            if(int.TryParse(out userResponse)) { 
                Console.WriteLine("The Entered value is a integer");
            }
        }
    }
}
