using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class StudentRepository
    {
        public void Save(Student student)
        {
            Logger.Log("Starting Save()");
            Logger.Log($"{student.FirstName} is added");
            Logger.Log("Ending Saving()");
        }
        public void Delete(Student student) 
        {
            Logger.Log("Starting Delete()");
            Logger.Log($"{student.FirstName} is deleted");
            Logger.Log("Ending Delete()");
        }
        public void SaveCourse(Student student)
        {
            Logger.Log("Starting SaveCourse()");
            Logger.Log($"{student.FirstName} course is saved");
            Logger.Log("Ending SaveCourse()");
        }
    }
}
