using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Calkulator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter arithmetic expression: ");
            string expression = Console.ReadLine();
            string[] element = expression.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string element1 = element[0];
            string element2 = element[1];
            if ((element1 == "sqr") || (element1 == "sqrt"))
            {
                double number = double.Parse(element2);
                switch (element1)
                {
                    case "sqr":
                        Console.WriteLine("sqr {0} = {1}", number, Math.Sqrt(number));
                        break;
                    case "sqrt":
                        Console.WriteLine("sqrt {0} = {1}", number, Math.Sqrt(number));
                        break;
                    default:
                        Console.WriteLine("mistake");
                        break;
                }
            }
            else
            {
                string element3 = element[2];
                double firstNumber = double.Parse(element1);
                double secondNumber = double.Parse(element3);
                switch (element2)
                {
                    case "+":
                        Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, firstNumber + secondNumber);
                        break;
                    case "-":
                        Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, firstNumber - secondNumber);
                        break;
                    case "*":
                        Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, firstNumber * secondNumber);
                        break;
                    case "/":
                        Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, firstNumber / secondNumber);
                        break;
                    case "%":
                        Console.WriteLine("{0} % {1} = {2}", firstNumber, secondNumber, firstNumber % secondNumber);
                        break;
                    case "pow":
                        Console.WriteLine("{0} pow {1} = {2}", firstNumber, secondNumber, Math.Pow(firstNumber, secondNumber));
                        break;
                    default:
                        Console.WriteLine("mistake");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
