using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();


            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add");
                    Calcul("1");

                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                    Calcul("2");

                    break;

                case "3":
                    Console.WriteLine("Enter 2 integers to multiple");
                    Calcul("3");

                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                    Calcul("4");

                    break;

                default:
                    Console.WriteLine(input + " isn't a choice.");
                    break;
            }
        }

        static void Calcul(string choice)
        {
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();
            var calculator = new Calculator();

            if (int.TryParse(number1, out int numOne) && int.TryParse(number2, out int numTwo))
            {
                switch(choice)
                {
                    case "1":
                        Console.Write($"{number1} + {number2} = ");
                        Console.Write(calculator.Add(numOne, numTwo));
                        break ;
                    
                    case "2":
                        Console.Write($"{number1} - {number2} = ");
                        Console.Write(calculator.Subtract(numOne, numTwo));
                        break ;
                        
                    case "3":
                        Console.Write($"{number1} * {number2} = ");
                        Console.Write(calculator.Multiply(numOne, numTwo));
                        break ;
                    
                    case "4":
                        Console.Write($"{number1} / {number2} = ");
                        Console.Write(calculator.Divide(numOne, numTwo));
                        break ;

                    default:
                        Console.WriteLine("wrong choice");
                        break;
                }    
                           
            }
            else {
                Console.WriteLine("One or more of the numbers is not an int");
            }
        }
    }
}