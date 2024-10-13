// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// int callTerminal = 

while (true) // бесконечный цикл
{
    string input = GetInput();

    if (IsExitCondition(input))
    {
        Console.WriteLine("Программа завершена.");
        break;
    }

    if (IsNumber(input, out int number))
    {
        if (IsSumOfDigitsEven(number))
        {
            Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");c
            break;
        }
        else
        {
            Console.WriteLine($"Сумма цифр числа {number} нечётная. Продолжаем.");
        }
    }
    else
    {
        Console.WriteLine("Введите корректное целое число или 'q' для выхода.");
    }
}

// Получение ввода от пользователя
static string GetInput()
{
    Console.Write("Введите целое число или 'q' для выхода: ");
    return Console.ReadLine();
}

// Проверка, является ли ввод символом для завершения
static bool IsExitCondition(string input)
{
    return input.ToLower() == "q";
}

// Проверка, является ли ввод числом
static bool IsNumber(string input, out int number)
{
    return int.TryParse(input, out number);
}

// Метод для вычисления суммы цифр числа
static int SumDigits(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += Math.Abs(num % 10); // добавляем последнюю цифру к сумме
        num /= 10; // удаляем последнюю цифру
    }
    return sum;
}

// Проверка, чётная ли сумма цифр числа
static bool IsSumOfDigitsEven(int num)
{
    int sumOfDigits = SumDigits(num);
    return sumOfDigits % 2 == 0;
}