using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3_Inheritance
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Team team = new Team();
            Sponser teamSponser= new Sponser();
            team.printInfo();
            teamSponser.printInfo();
            Sponser sponser2 = new Team();
            sponser2.printInfo();
        }
    }
    public class Sponser
    {
        protected string owner = "Rakuteen";
        public void printInfo()
        {
            Console.WriteLine($"Owner of team is {owner}");
        }
    }
    public class Team : Sponser
    {
        private string teamName = "Titans";
        //printInfo method prints the information about teamName and owner.
        public void printInfo()
        {
            Console.WriteLine($"Team name is {teamName} and the owner is {owner}");
        }
    }

}
