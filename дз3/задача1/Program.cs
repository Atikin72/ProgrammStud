// Задайте массив целых чисел. Напишите программу, которая проверяет,
// присутствует ли заданное число в массиве. Программа должна вывести:
// Присутствует/Не присутствует.

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.Write("Введите число для проверки: ");
int target = Convert.ToInt32(Console.ReadLine());

bool Found = false;

foreach (int number in numbers)
{
    if (number == target)
    {
        Found = true;
        break;
    }
}

if (Found)
{
    Console.WriteLine("Присутствует");
}
else
{
    Console.WriteLine("Не присутствует");
}