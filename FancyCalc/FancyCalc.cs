using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCalc
{
    public class FancyCalcEnguine
    {

        public double Add(int a, int b)
        {
            double d = a + b;
            return d;
            throw new NotImplementedException();
        }


        public double Subtract(int a, int b)
        {
            double c = a - b;
            return c;
            throw new NotImplementedException();
        }


        public double Multiply(int a, int b)
        {
            double k = a * b;
            return k;
        }

        //generic calc method. usage: "10 + 20"  => result 30
        public double Culculate(string expression)
        {
            throw new NotImplementedException();
        }
    }
}
