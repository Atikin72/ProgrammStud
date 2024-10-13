// Задание 4: Удаление всех отрицательных чисел
// Описание: Задайте массив целых чисел. Напишите программу, которая удаляет все
// отрицательные числа из массива и возвращает новый массив, содержащий только
// неотрицательные числа.

int[] array = new int[10];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 11); // ��енерация случайного числа от -10 до 10
}

Console.WriteLine("Элементы массива:"); // Выводим массив
PrintArray(array);

int[] nonNegativeArray = RemoveNegativeNumbers(array);

Console.WriteLine("Новый массив (без отрицательных чисел):");
PrintArray(nonNegativeArray);

static void PrintArray(int[] array)// Метод для вывода массива
{
    foreach (int number in array)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine();
}

static int[] RemoveNegativeNumbers(int[] array)
{
    // Считаем количество неотрицательных чисел
    int count = 0;
    foreach (int number in array)
    {
        if (number >= 0)
        {
            count++;
        }
    }

    // Создаем новый массив нужного размера
    int[] nonNegativeArray = new int[count];
    int index = 0;

    // Заполняем новый массив неотрицательными числами
    foreach (int number in array)
    {
        if (number >= 0)
        {
            nonNegativeArray[index] = number;
            index++;
        }
    }

    return nonNegativeArray; // Возвращаем новый массив
}
