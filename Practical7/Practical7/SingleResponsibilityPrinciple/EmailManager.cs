using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class EmailManager
    {
        public static void SendEmail(Student student)
        {
            Console.WriteLine($"Email sent successfully sent to {student.Email} ID");
        }
    }
}
