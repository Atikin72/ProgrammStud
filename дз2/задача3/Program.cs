// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.WriteLine("Введите число от 10 до 99: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10 && number <= 99)
{
    int firstDigit = number / 10;  // первая цифра числа
    int secondDigit = number % 10; // вторая цифра числа

    //int maxDigit = Math.Max(firstDigit, secondDigit); //используем метод Math.Max() для нахождения наибольшей цифры.

    //Console.WriteLine($"Наибольшая цифра числа {number} -> {maxDigit}");
    if (firstDigit > secondDigit)
    {
        Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDigit}");
    }
    else if (secondDigit > firstDigit)
    {
        Console.WriteLine($"Наибольшая цифра числа {number} -> {secondDigit}");
    }
}
else
{
    Console.WriteLine("Ошибка! Введите число из диапазона от 10 до 99.");
}