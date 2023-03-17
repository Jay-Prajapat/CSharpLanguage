using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFruit fruit = new Orange();
            fruit.GetColor();
            fruit = new Apple();
            fruit.GetColor();
        }
    }

    public interface IFruit
    {
        void GetColor();
    }

    public class Apple : IFruit
    {
        public void GetColor()
        {
            Console.WriteLine("Color is Red");
        }
    }

    public class Orange : IFruit
    {
        public void GetColor()
        {
            Console.WriteLine("Color is Orange");
        }
    }
}
