using System;

namespace ImprovedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Улучшенный калькулятор ---");

            Console.WriteLine("Введите первое число:");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите символ операции (+, -, *, /):");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Результат: {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                    break;

                case "-":
                    Console.WriteLine($"Результат: {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                    break;

                case "*":
                    Console.WriteLine($"Результат: {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                    break;

                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль невозможно!");
                    }
                    else
                    {
                        Console.WriteLine($"Результат: {firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                    }
                    break;

                default:

                    Console.WriteLine($"Ошибка: неизвестная операция \"{operation}\". Допустимые символы: +, -, *, /");
                    break;
            }
        }
    }
}