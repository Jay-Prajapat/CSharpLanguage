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
        ILogger _logger;
        IEmailer _emailer;


        public Task(ILogger logger, IEmailer emailer)
        {
            _logger = logger;
            _emailer = emailer;
        }
        public string TaskName { get; set; }
        public IPerson Owner { get; set; }

        public double HoursWorked { get; private set; }
        public bool IsCompleted { get; private set; }
        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on {TaskName} taking hours {HoursWorked}");
        }

        public void TaskCompolete()
        {
            IsCompleted = true;
            _logger.Log($"Completed {TaskName}");

            _emailer.SendEmail(Owner, $"The Task {TaskName} is complete.");

        }
    }
}
