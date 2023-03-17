using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegrigationPrinciple
{
    public class HPPrinter : IPrinter, IPrintDuplicates, IPrintColour
    {
        public void Print(string printContent)
        {
            Console.WriteLine($"HPPrinter : Printing Complete : {printContent}");
        }

        public void Scan(string scanContent)
        {
            Console.WriteLine($"HPPrinter : Sacn Complete: {scanContent}");
        }

        public void PrintDuplicates(string duplicateContent)
        {
            Console.WriteLine($"HPPrinter : Printing Duplicate Content: {duplicateContent}");
        }

        public void ColourPrint(string colourContent)
        {
            Console.WriteLine($"HPPrinter : Printing Complete : {colourContent}");
        }
    }
}
