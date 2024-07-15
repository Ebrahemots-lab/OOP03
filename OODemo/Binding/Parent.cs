using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODemo.Binding
{
    public class Parent
    {
        public int A { get; set; }

        public void Walk()
        {
            Console.WriteLine("Iam Parent Iam Walking");
        }

        public virtual void Move() 
        {
            Console.WriteLine("Iam parent iam moving");
        }
    }
}
