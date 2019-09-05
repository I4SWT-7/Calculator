using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalcMethods
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }


        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Power(int num1, int num2)
        {
            return Math.Pow(num1, num2);
        }


        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public double squareroot(int num1)
        {
            return Math.Sqrt(num1);
        }
    }
}

