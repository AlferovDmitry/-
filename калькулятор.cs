using System;

class Calculator
{
    static void Main(string[] args)
    {
        bool continueCalculating = true;

        while (continueCalculating)
        {
            Console.WriteLine("Введите первое число:");
            bool isFirstNumberValid = int.TryParse(Console.ReadLine(), out int number1);
            if (!isFirstNumberValid)
            {
                Console.WriteLine("Преобразование завершилось неудачно. Введите корректное число.");
                continue;
            }

            Console.WriteLine("Введите второе число:");
            bool isSecondNumberValid = int.TryParse(Console.ReadLine(), out int number2);
            if (!isSecondNumberValid)
            {
                Console.WriteLine("Преобразование завершилось неудачно. Введите корректное число.");
                continue;
            }

            Console.WriteLine("Выберите операцию (+, -, *, /):");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Для перехода на новую строку

            double result;

            switch (operation)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine($"Результат: {result}");
                    break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine($"Результат: {result}");
                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine($"Результат: {result}");
                    break;

                case '/':
                    if (number2 != 0)
                    {
                        result = (double)number1 / number2;
                        Console.WriteLine($"Результат: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Деление на ноль.");
                    }
                    break;

                default:
                    Console.WriteLine("Неизвестная операция.");
                    break;
            }

            Console.WriteLine("Хотите продолжить? (да/нет):");
            string userResponse = Console.ReadLine().ToLower();
            if (userResponse != "да")
            {
                continueCalculating = false;
            }
        }

        Console.WriteLine("Спасибо за использование калькулятора!");
    }
}
