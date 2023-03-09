using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListEXample
{
    public class Employee
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(100);
            arrayList.Add("jay");
            arrayList.Add(true);
            arrayList.Add(null);
            arrayList.Add(50);
            foreach (var arrlst in arrayList)
            {
                Console.WriteLine(arrlst);
            }
            arrayList.Insert(2, 300);
            arrayList.Remove(50);
            arrayList.RemoveAt(2);
            arrayList.RemoveRange(0, 2);
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);

            }
            arrayList.Clear();

            string[] arr = { "hi", "hello" };
            Console.WriteLine(arr);

            Employee employee = new Employee();

            var type = typeof(Employee);
            if (typeof(Employee) == employee.GetType())
            {
                Console.WriteLine(type);
                Console.WriteLine(employee.GetType());
                Console.WriteLine("true");

            }

            ArrayList arr1 = new ArrayList();
            arr1.Add(1);
            arr1.Add("hi");
            arr1.Add(2);
            Console.WriteLine("---------------------------------");

            foreach (var arrElement in arr1)
            {
                Console.WriteLine(arrElement);
            }
            Console.WriteLine("---------------------------------");


            ArrayList arr2 = (ArrayList)arr1.Clone();
            foreach (var arrElement in arr2)
            {
                Console.WriteLine(arrElement);
            }
            Console.WriteLine("---------------------------------");

            arr2.Add("hello");
            foreach (var arrElement in arr1)
            {
                Console.WriteLine(arrElement);
            }
            Console.WriteLine("---------------------------------");

            foreach (var arrElement in arr2)
            {
                Console.WriteLine(arrElement);
            }
            Console.WriteLine("---------------------------------");

            arr1[1] = "hello world";
            foreach (var arrElement in arr1)
            {
                Console.WriteLine(arrElement);
            }
            Console.WriteLine("---------------------------------");

            foreach (var arrElement in arr2)
            {
                Console.WriteLine(arrElement);
            }
        }
    }
}
