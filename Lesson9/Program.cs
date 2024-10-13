// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3


// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max);
//     }

//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1)
//         {
//             Console.Write($"{array[i]}, ");
//         }
//         else
//         {
//             Console.Write($"{array[i]}");
//         }
//     }
//     Console.Write("]");
// }

// int CountPrimeNumbers(int[] array)
// {
//     int count = 0;
//     // реализация
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (IsPrime(array[i]))
//         {
//             count++;
//         }
//     }

//     return count;
// }

// bool IsPrime(int num)
// {
//     for (int i = 2; i <= Math.Sqrt(num); i++)
//     {
//         if (num % i == 0)
//         {
//             return false;
//         }
//     }
//     return true;
// }

// int[] arr = CreateArrayRndInt(10, 1, 100);
// PrintArray(arr);

// int countPrime = CountPrimeNumbers(arr);
// Console.Write($" => {countPrime}");

// __________________________________________

// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3] => 2

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max);
//     }

//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1)
//         {
//             Console.Write($"{array[i]}, ");
//         }
//         else
//         {
//             Console.Write($"{array[i]}");
//         }
//     }
//     Console.Write("]");
// }

// int CountLastADev(int[] array, int aLast, int bDev)
// {
//     int count = 0;
//     // реализация
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 10 == aLast && array[i] % bDev == 0)
//         {
//             count++;
//         }
//     }
//     return count;

// }    

// Console.Write("Введите число размера массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] arr = CreateArrayRndInt(n, 1, 100);
// PrintArray(arr);
// int result = CountLastADev(arr, 1, 7);
// Console.Write("> " + result);

// __________________________________________

// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

int ArrayToNumber(int[] array)

{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        res = res * 10 + array[i];
    }
    return res;
}

Console.Write("Введите число размера массива: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 8 || n < 0)
{
    Console.WriteLine("Неверный размер массива!");
    return;
}

int[] arr = CreateArrayRndInt(n, 0, 10);
PrintArray(arr);

int number = ArrayToNumber(arr);
Console.Write($"> {number}");

