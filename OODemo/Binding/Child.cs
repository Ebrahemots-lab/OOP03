using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODemo.Binding
{
    public class Child : Parent
    {
        public int B { get; set; }

        public new void Walk() 
        {
            Console.WriteLine("Iam Child Iam Walking");
        }

        public override void Move()
        {
            Console.WriteLine("Iam Child iam moving");
        }
    }
}
