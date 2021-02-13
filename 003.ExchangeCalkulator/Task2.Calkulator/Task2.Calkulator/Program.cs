using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Calkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter the second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter the operand (+, -, *, /, %): ");
            char operand = Convert.ToChar(Console.ReadLine());
            switch (operand)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", firstNumber, secondNumber, firstNumber + secondNumber);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", firstNumber, secondNumber, firstNumber - secondNumber);
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", firstNumber, secondNumber, firstNumber * secondNumber);
                    break;
                case '/':
                    Console.WriteLine("{0}/{1}={2}", firstNumber, secondNumber, firstNumber / secondNumber);
                    break;
                case '%':
                    Console.WriteLine("{0}%{1}={2}", firstNumber, secondNumber, firstNumber % secondNumber);
                    break;
                default:
                    Console.WriteLine("mistake");
                    break;
            }
            Console.ReadLine();
        }
    }
}
