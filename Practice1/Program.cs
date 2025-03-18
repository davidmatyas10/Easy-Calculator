using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Vítej v kalkulačce");
                string operation = GetOperation("Zadej operaci (+, -, *, /) nebo napište 'exit' pro ukončení programu:");

                if (operation == "exit")
                    break;

                double number1 = GetNumber("Zadej první číslo:");
                double number2 = GetNumber("Zadej druhé číslo:");
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        Console.WriteLine($"{number1} + {number2} = {result}");
                        break;
                    case "-":
                        result = number1 - number2;
                        Console.WriteLine($"{number1} - {number2} = {result}");
                        break;
                    case "*":
                        result = number1 * number2;
                        Console.WriteLine($"{number1} * {number2} = {result}");
                        break;
                    case "/":
                        if (number1 == 0 || number2 == 0)
                        {
                            Console.WriteLine("Nelze dělit nulou");
                        }
                        else
                        {
                            result = number1 / number2;
                            Console.WriteLine($"{number1} / {number2} = {result}");
                        }
                        break;
                    default:
                        Console.WriteLine("Neznámá operace");
                        continue;
                }

                Console.ReadLine();
            }
        }
        static double GetNumber(string number)
        {
            while (true)
            {
                Console.WriteLine(number);
                if (double.TryParse(Console.ReadLine(), out double num))
                {
                    return num;
                }
                Console.WriteLine("Neplatný vstup! Zadejte číslo!");
            }
        }
        static string GetOperation(string Operation)
        {
            while (true)
            {
                Console.WriteLine(Operation);
                string operation = Console.ReadLine().ToLower();

                if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                {
                    return operation;
                }
                else if (operation == "exit")
                {
                    return "exit";
                }

                Console.WriteLine("Neplatná operace! Zadej jednu z možností: +, -, *, / nebo 'exit' pro ukončení.");
            }
        }
    }
}
