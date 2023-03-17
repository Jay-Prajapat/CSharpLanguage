using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegrigationPrinciple
{
    public class DellPrinter : IPrinter
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine($"DellPrinter : Printing Complete : {PrintContent}");
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine($"DellPrinter : Scanning Content : {ScanContent}");
        }
    }
}
