﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalcMethods
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

        public int Power(int num1, int num2)
        {
            return num1 ^ num2;
        }
    }
}