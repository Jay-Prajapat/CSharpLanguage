using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3_Inheritance
{
    internal class Program
    {
        public class Sponser
        {
            protected string owner = "Rakuteen";
        }
        public class Team : Sponser
        {
            private string teamName="Titans";
            public void printInfo() 
            {
                Console.WriteLine($"Team name is {teamName} and the owner is {owner}");
            }
        }
        static void Main(string[] args)
        {
            Team team = new Team();
            team.printInfo();
        }
    }
}
