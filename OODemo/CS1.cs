using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODemo
{
    public class CS1
    {
        public int Sum(int x , int y) 
        {
            return x + y;
        }

        public int Sum(int x , int y , int z) 
        {
            return x + y + z;
        }

        public double Sum(int x , double y) 
        {
            return x + y;
        }
        public double Sum(double y , int x) 
        {
            return y + x;   
        }
    }
}
