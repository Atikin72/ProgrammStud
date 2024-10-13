// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int size = 10; // размер массива
int[] array = CreateArray(size);
PrintArray(array);

int evenCount = CountEvenNumbers(array);
Console.WriteLine($"\nКоличество чётных чисел в массиве: {evenCount}");


// Функция создания массива, заполненного случайными трёхзначными числами
static int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(100, 1000); // генерация случайного трёхзначного числа
    }

    return array;
}

// Функция для вывода массива на консоль
static void PrintArray(int[] array)
{
    Console.Write("Массив: ");
    foreach (int num in array)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

// Функция для подсчета количества чётных чисел в массиве
static int CountEvenNumbers(int[] array)
{
    int count = 0;

    foreach (int num in array)
    {
        if (IsEven(num))
        {
            count++;
        }
    }

    return count;
}

// Функция для проверки, является ли число чётным
static bool IsEven(int num)
{
    return num % 2 == 0;
}
