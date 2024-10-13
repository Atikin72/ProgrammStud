// Замена элементов массива
// Описание: Задайте массив из 10 элементов, заполненный числами от -10 до 10.
// Замените отрицательные числа на их абсолютные значения, а положительные числа
// на их отрицательные эквиваленты.

Random random = new Random();
int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-10, 11); // Генерация случайного числа от -10 до 10
}

Console.WriteLine("Исходный массив:"); // Выводим исходный массив
PrintArray(array);

for (int i = 0; i < array.Length; i++) // Заменяем элементы
{
    array[i] *= -1; // Умножаем на -1, чтобы поменять знак
}

Console.WriteLine("Измененный массив:"); // Выводим измененный массив

PrintArray(array);


static void PrintArray(int[] array) // Метод для вывода массива
{
    foreach (int number in array)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine();
}