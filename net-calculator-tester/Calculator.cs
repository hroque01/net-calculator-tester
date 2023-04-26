using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public class Calculator
    {
        public float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        public float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        public float Divide(float num1, float num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }

            return num1 / num2;
        }

        public float Multiply(float num1, float num2)
        {
            if (num2 == 0) throw new Exception("Una numero diviso per 0 non produce alcun risultato");
            return num1 * num2;
        }
    }
}
