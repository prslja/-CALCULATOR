using System;
namespace BroCode
{
    class Program
    {
        static void Main(string[] args)
        {
            double numb1 = 0;
            double numb2 = 0;
            double result = 0;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Calculator");
            Console.WriteLine("------------------------------------");

            Console.Write("Enter number 1: ");
            numb1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter number 2: ");
            numb2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an option: ");
            Console.WriteLine("Add : +");
            Console.WriteLine("Subtract : -");
            Console.WriteLine("Multiply : *");
            Console.WriteLine("Devide : /");
            Console.Write("Enter an option: ");

            switch (Console.ReadLine())
            {
              case "+":
                    result = numb1 + numb2;
                    Console.WriteLine("Result: " + result);
                    break;
              case "-":
                    result = numb1 - numb2;
                    Console.WriteLine("Result: " + result);
                    break;
              case "*":
                    result = numb1 * numb2;
                    Console.WriteLine("Result: " + result);
                    break;
              case "/":
                    result = numb1 / numb2;
                    Console.WriteLine("Result: " + result);
                    break;
              default:
                    Console.WriteLine("Invalid option ");
                    break;
            }







            Console.ReadKey();

            Console.WriteLine("Thanks for playing :)");
            
        }
    }
}