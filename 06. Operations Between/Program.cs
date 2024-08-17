using System;

namespace _6._Operations_Between
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем: num1, num2, оператор
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            //2. Проверяваме 
            if (operation == "+" || operation == "-" || operation == "*")
            {
                int result;
                if (operation == "+")
                {
                    result = num1 + num2;
                }
                else if (operation == "-")
                {
                    result = num1 - num2;
                }
                else //(*)
                {
                    result = num1 * num2;
                }

                string evenOrOdd = "even";
                if (result % 2 != 0)
                {
                    evenOrOdd = "odd";
                }

                Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");
            }
            else //(/) или (%)
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else //aко не е =>
                {
                    double result;
                    if (operation == "/")
                    {
                        result = (double)num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result:f2}");
                    }
                    else//при (%) 
                    {
                        result = num1 % num2;
                        Console.WriteLine($"{num1} % {num2} = {result}");
                    }
                }
            }
        }
    }
}
