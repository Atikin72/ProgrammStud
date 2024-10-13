// Задание 3: Поиск среднего значения массива
// Описание: Задайте массив из 10 целых чисел. Найдите среднее значение элементов
// массива.
// Создаем массив из 10 целых чисел
int[] array = new int[10];
Random random = new Random();

for (int i = 0; i < array.Length; i++)// Заполняем массив случайными числами от -10 до 10
{
    array[i] = random.Next(-10, 11); // Генерация случайного числа от -10 до 10
}

Console.WriteLine("Элементы массива:"); // Выводим массив
PrintArray(array);

double average = CalculateAverage(array); // Вычисляем среднее значение

Console.WriteLine($"Среднее значение элементов массива: {average}");// Выводим среднее значение

static void PrintArray(int[] array)// Метод для вывода массива
{
    foreach (int number in array)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine();
}

static double CalculateAverage(int[] array)    // Метод для вычисления среднего значения
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)        // Суммируем элементы массива
    {
        sum += array[i];
    }

    return (double)sum / array.Length;        // Возвращаем среднее значение
}