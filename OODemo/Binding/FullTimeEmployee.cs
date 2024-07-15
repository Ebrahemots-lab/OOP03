using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODemo.Binding
{
    public class FullTimeEmployee : Employee
    {
        public double Salary { get; set; }

        public FullTimeEmployee(int id , string name , int age , double salary) :base(id , name , age)
        {
            Salary = salary;
        }

        public new void GetEmployeeType() 
        {
            Console.WriteLine("Iam Full Time Employee");
        }

        public override void GetEmpData()
        {
            Console.WriteLine($"{Id} - {Name} : {Age} - {Salary}");
        }
    }
}
