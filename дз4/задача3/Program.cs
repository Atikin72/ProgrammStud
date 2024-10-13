// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)


void ReverseArray(int[] array)
{
    int left = 0;
    int right = array.Length - 1;
    
    while (left < right)
    {
        int temp = array[left];
        array[left] = array[right];
        array[right] = temp;
        
        left++;
        right--;
    }
}

// Функция для вывода массива
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

// Основная часть программы
int[] arr = { 1, 2, 3, 4, 5, 6 };
Console.WriteLine("Исходный массив:");
PrintArray(arr);

ReverseArray(arr);

Console.WriteLine("Перевернутый массив:");
PrintArray(arr);