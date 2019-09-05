using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    class Program
    { 
        static void Main(string[] args)
        {
            CalcMethods MyCalc = new CalcMethods();
            
            while (true)
            { 
            int num1 = 0;
            int num2 = 0;
            double result = 0;

            Console.WriteLine("Welcome to Calculator\r");
            Console.WriteLine("---------------------\n");

            Console.WriteLine("Type a number, then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type another number, then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\tp - Power");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("\tq - Squareroot");

            Console.Write("Your option? ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "a":
                     result = MyCalc.Add(num1, num2);
                    break;
                case "s":
                    result = MyCalc.Subtract(num1, num2);
                    break;
                case "m":
                    result = MyCalc.Multiply(num1, num2);
                    break;
                case "p":
                    result = MyCalc.Power(num1, num2);
                    break;
                case "d":
                    result = MyCalc.Divide(num1, num2);
                    break;
                case "q":
                    result = MyCalc.squareroot(num1);
                    break;
            }

            // Wait for the user to respond before closing.
            Console.WriteLine(result);
            Console.Write("Press any key to start over the Calculator console app... \n");
            Console.ReadKey();
        }

    }
}
}
