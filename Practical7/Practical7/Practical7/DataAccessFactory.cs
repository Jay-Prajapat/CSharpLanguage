using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical7
{
    public class DataAccessFactory
    {
        public static IEmployeeDataAccessLogic GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccessLogic();
        }

        public static IPerson CreatePersion()
        {
            return new Person();
        }

        public static ILogger CreateLogger()
        {
            return new Logger();    
        }

        public static ITask CreateTask()
        {
            return new Task();  
        }

        public static IEmailer CreateEmailer()
        {
            return new Emailer();
        }
    }
}
