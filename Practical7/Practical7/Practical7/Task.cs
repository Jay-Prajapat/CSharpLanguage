using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical7
{
    public class Task : ITask
    {
        public string TaskName { get; set; }
        public IPerson Owner { get; set; }

        public double HoursWorked { get; private set; }
        public bool IsCompleted { get; private set; }
        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            Logger log = new Logger();
            log.Log($"Performed work on {TaskName} taking hours {HoursWorked}");
        }

        public void TaskCompolete()
        {
            IsCompleted = true;
            ILogger log = new Logger();
            log.Log($"Completed {TaskName}");

            IEmailer emailer = new Emailer();
            emailer.SendEmail(Owner, $"The Task {TaskName} is complete.");

        }
    }
}
