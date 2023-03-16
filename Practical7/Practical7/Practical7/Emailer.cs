using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical7
{
    public class Emailer : IEmailer
    {
        public void SendEmail(IPerson person, string message)
        {
            Console.WriteLine($"Sending an email to {person.EmailAddress}");
        }
    }
}
