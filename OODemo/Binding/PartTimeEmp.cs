using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODemo.Binding
{
    public class PartTimeEmp : Employee
    {
        public new void GetEmployeeType() 
        {
            Console.WriteLine("Iam PartTime Emp");
        }

        public override void GetEmpData()
        {
            Console.WriteLine($"id: {Id} - Name: {Name} - Age: {Age}");
        }
    }
}
