using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            laptop.LaptopDetails();
            //laptop.MotherBoardInfo();
           //MotherBoardInfo is not accessible because it is private in laptop class so we can only access it into
           //Laptop class only so this way we can protect our implementation and achive abstraction.                                                  
        }
    }
    public class Laptop
    {
        private string brand;
        private string model;
        //public method that gives the details about laptop brand and model.
        public void LaptopDetails()
        {
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Model: {model}");
        }
        //private method that gives information about MotherBoard of laptop.
        private void MotherBoardInfo()
        {
            Console.WriteLine("Mother board information");
        }
    }
}
