// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int middle = FindMiddleNumber(num1, num2, num3);

// Console.WriteLine($"Среднее число: {middle}");

// static int FindMiddleNumber(int a, int b, int c)
// {
//     if ((a > b && a < c) || (a > c && a < b))
//         {
//         return a;
//         }
//     else if ((b > a && b < c) || (b > c && b < a))
//         {
//         return b;
//         }
//     else
//         {
//         return c;
//         }
// }

//________________________________________________________________

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите три числа через пробел: ");
        string? input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Ошибка: ввод не может быть пустым.");
            return; // Завершаем программу, если строка пуста
        }

        // Разделяем введенную строку на три части
        string[] numbers = input.Split(' ');

        if (numbers.Length != 3)
        {
            Console.WriteLine("Ошибка: необходимо ввести ровно три числа.");
            return; // Завершаем программу, если количество чисел неверное
        }

        // Преобразуем каждую часть в целое число
        int num1 = Convert.ToInt32(numbers[0]);
        int num2 = Convert.ToInt32(numbers[1]);
        int num3 = Convert.ToInt32(numbers[2]);

        int middle = FindMiddleNumber(num1, num2, num3);

        Console.WriteLine($"Среднее число: {middle}");
    }

    static int FindMiddleNumber(int a, int b, int c)
    {
        // Логика для нахождения среднего числа
        if ((a > b && a < c) || (a > c && a < b))
        {
            return a;
        }
        else if ((b > a && b < c) || (b > c && b < a))
        {
            return b;
        }
        else
        {
            return c;
        }
    }
}