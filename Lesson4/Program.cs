// Создание двухмерного массива с рандомными числами 
// int[,] matrix = new int[3, 5];

// Random rnd = new Random();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//    {

//         matrix[i, j] = rnd.Next(1, 11);
//     }
// }
// Вывод кода двухмерного массива
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

//________________________________________________________________
// Заполнение двухмерного массива с квадратными числами

//int[,] CreateMatrix(int rowCount, int columsCount)
//{
//    int[,] matrix = new int[rowCount, columsCount];
//
//    Random rnd = new Random();
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//
//            matrix[i, j] = rnd.Next(1, 11);
//        }
//    }
//    return matrix;
//}

//void ShowMatrix(int[,] matrix)
//{
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//            Console.Write($"{matrix[i, j]} ");
//        }
//        Console.WriteLine();
//    }
//}
// функции пример
//int[,] matrix = CreateMatrix(6,8);
//ShowMatrix(matrix);

//________________________________________________________________


//int[,] CreateMatrix(int rowCount, int columsCount)
//{
//    int[,] matrix = new int[rowCount, columsCount];
//
//    Random rnd = new Random();
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//            matrix[i, j] = rnd.Next(1, 1001); // Генерация чисел от 1 до 1000
//        }
//    }
//    return matrix;
//}

//void ShowMatrix(int[,] matrix)
//{
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//            Console.Write($"{matrix[i, j]} "); // Вывод элементов матрицы
//        }
//        Console.WriteLine(); // Переход на новую строку после каждой строки матрицы
//    }
//}

//int[,] matrix = CreateMatrix(6, 8);
//ShowMatrix(matrix);

//foreach (int e in matrix)
//{
//    if (isInteresting(e)) // Убрал лишнее сравнение с true
//    {
//        Console.WriteLine(e); // Вывод интересных чисел
//    }
//}

//bool isInteresting(int number)
//{
//    int sumOfDigit = GetSumOfDigit(number); // Исправлено название функции
//    return sumOfDigit % 2 == 0; // Если сумма цифр чётная, число интересное
//}

//int GetSumOfDigit(int number)
//{
//    int sum = 0;
//    while (number > 0)
//    {
//        sum += number % 10; // Добавляем последнюю цифру числа к сумме
//        number /= 10; // Уменьшаем число, отбрасывая последнюю цифру
//    }
//    return sum;
//}

//________________________________________________________________

//Текстовый массив 

string GetLettersFromString(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (Char.IsLetter(e))
        {
            letters += e;
        }
    }
    return letters;
}

string str = Console.ReadLine();
string result = GetLettersFromString(str);
Console.WriteLine(result);