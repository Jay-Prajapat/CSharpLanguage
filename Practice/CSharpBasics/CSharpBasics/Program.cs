using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Reach Dad Poor Dad");
            book.AddGrade(12.3);
            book.AddGrade(15.3);
            book.AddGrade(3.23);
            book.showStatstics();
        }
    }
}
