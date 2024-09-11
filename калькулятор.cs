// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        double result = 0;
        bool firstOperation = true;

        Console.WriteLine("Консольный калькулятор");
        Console.WriteLine("Введите 'exit' для выхода.");

        while (true)
        {
            if (firstOperation)
            {
                Console.Write("Введите первое число: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit") break;

                if (double.TryParse(input, out result))
                {
                    firstOperation = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Попробуйте снова.");
                    continue;
                }
            }

            Console.Write("Введите оператор (+, -, *, /) или 'exit' для выхода: ");
            string operation = Console.ReadLine();
            if (operation.ToLower() == "exit") break;

            Console.Write("Введите следующее число: ");
            string nextInput = Console.ReadLine();
            if (nextInput.ToLower() == "exit") break;

            if (double.TryParse(nextInput, out double nextNumber))
            {
                switch (operation)
                {
                    case "+":
                        result += nextNumber;
                        break;
                    case "-":
                        result -= nextNumber;
                        break;
                    case "*":
                        result *= nextNumber;
                        break;
                    case "/":
                        if (nextNumber != 0)
                            result /= nextNumber;
                        else
                            Console.WriteLine("Ошибка: деление на ноль.");
                        break;
                    default:
                        Console.WriteLine("Неверный оператор. Попробуйте снова.");
                        continue;
                }

                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Неверный ввод. Попробуйте снова.");
            }
        }

        Console.WriteLine("Выход из калькулятора. До свидания!");
    }
}
