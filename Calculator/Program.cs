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
            
            int num1 = 0;
            int num2 = 0;

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
            Console.WriteLine("\td - Power");
            Console.Write("Your option? ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "a":
                    int AddResult = MyCalc.Add(num1, num2);
                    break;
                case "s":
                    int SubResult = MyCalc.Subtract(num1, num2);
                    break;
                case "m":
                    int MultiplyResult = MyCalc.Multiply(num1, num2);
                    break;
                case "d":
                    int PowerResult = MyCalc.Power(num1, num2);
                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app... ");
            Console.ReadKey();
        }

    }
}
