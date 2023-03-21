using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8
{
    internal class Program
    {          
        static void Main(string[] args)
        {
            IStudent student = new Customer();
            Console.WriteLine("Enter first name of the student");
            student.FirstName= Console.ReadLine();
            Console.WriteLine("Enter last name of the student");
            student.LastName= Console.ReadLine();
            
            Console.WriteLine("Enter email of the student");
            student.Email = Console.ReadLine();

            try
            {
                Console.WriteLine("Enter age of the student");
                student.Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter phone number of the student"); 
                student.PhoneNumber = int.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

              
        }
    }
}
