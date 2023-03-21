using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8
{
    public class Admin
    {
        List<Customer> customers = new List<Customer>();
        public void AddUser(Customer customer)
        {
            customers.Add(customer);
        }
        public void RemoveUser(string name)
        {
            customers.Remove(customer);
        }
    }
}
