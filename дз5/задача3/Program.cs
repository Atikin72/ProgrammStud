// Задание 3: Транспонирование двумерного массива
// Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
// // транспонирует массив (меняет строки и столбцы местами).

// Пример входных данных:
// 1 2
// 3 4
// 5 6
// Пример результата:
// 1 3 5
// 2 4 6



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

// Функция для вывода двумерного массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

// Функция для транспонирования двумерного массива
int[,] TransposeMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] transposedMatrix = new int[columns, rows]; // Меняем местами строки и столбцы

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            transposedMatrix[j, i] = matrix[i, j];
        }
    }
    return transposedMatrix;
}

// Основная программа
int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
Console.WriteLine("Исходный массив:");
PrintMatrix(array2d);

Console.WriteLine("\nТранспонированный массив:");
int[,] transposedArray = TransposeMatrix(array2d);
PrintMatrix(transposedArray);
