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
            while (true)
            {
                Console.Clear();
                double FirstValue, SecondValue;
                string Action;

                try
                {
                    Console.WriteLine("Write FirstValue");
                    FirstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Select an Action: '+' '-' '*' '/' '%' ");
                    Action = Console.ReadLine();

                    Console.WriteLine("Write SecondValue");
                    SecondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Unknown Value");
                    Console.ReadLine();
                    continue;
                }

                if (Action == "+")
                {
                    Console.WriteLine($"{"AddValue"} {'='} {FirstValue + SecondValue}");
                }

                else if (Action == "-")
                {
                    Console.WriteLine($"{"SubValue"} {'='} {FirstValue - SecondValue}");
                }

                else if (Action == "*")
                {
                    Console.WriteLine($"{"MulValue"} {'='} {FirstValue * SecondValue}");
                }

                else if (Action == "/")
                {
                    if (SecondValue == 0)
                        Console.WriteLine("Cannot be divided by 0");
                    else
                        Console.WriteLine($"{"DivValue"} {'='} {FirstValue / SecondValue}");
                }

                else if (Action == "%")
                {
                    Console.WriteLine($"{"RestValue"} {'='} {FirstValue % SecondValue}");
                }

                else
                {
                    Console.WriteLine("Unknown Action");
                }
                Console.ReadLine();
            }
        }
    }
}
