using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class PaymentManager
    {
        public static void PaymentProcess(Student student)
        {
            Console.WriteLine($"Payment Completed for {student.FirstName}");
        }
    }
}
