// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
// 4 3 4 1 =>
// 2 9 5 4
// 4 3 16 3
// 4 3 4 1
// 4 9 25 4


// int[,] CreateMatrixRndInt(int rown, int columns, int min, int max)
// {
//     int[,] matrix = new int[rown, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//         matrix[i,j] = rnd.Next(min, max);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//         Console.Write($"{matrix[i,j]} ");
//         }
//         Console.WriteLine("]");
//     }
// }

// void SquareEvenNumMatrix(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i+=2)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j+=2)
//         {
//         // if (i % 2 == 0 && j % 2 == 0)
//         // {
//             matrix[i, j] *= matrix[i, j];
//         // }
//         }
//     }
// }

// Console.WriteLine("Изначальный массив");
// int[,] array2d = CreateMatrixRndInt(3, 4, 1, 100);
// PrintMatrix(array2d);

// Console.WriteLine("Изменёный массив");

// SquareEvenNumMatrix(array2d);
// PrintMatrix(array2d);

// ___________________________________________________________________

// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
// 4 3 4 1 => 2 + 3 + 5 = 10
// 2 9 5 4

// int[,] CreateMatrixRndInt(int rown, int columns, int min, int max)
// {
//     int[,] matrix = new int[rown, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//         matrix[i,j] = rnd.Next(min, max);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//         Console.Write($"{matrix[i,j]} ");
//         }
//         Console.WriteLine("]");
//     }

// }

// int SumMainDiagonal(int[,] matrix)
// {
// int sum = 0;

//        // int minSize = matrix.GetLength(0);
//        // if(matrix.GetLength(1) < minSize)
//        // {
//        // minSize = matrix.GetLength(1);
//        // }

// for(int d = 0; d < matrix.GetLength(0) && d < matrix.GetLength(1); d++)
// {
// sum = sum + matrix[d,d]; // sum += matrix[i, i];
// }
// return sum;
// }

// int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
// PrintMatrix(array2d);

// Console.WriteLine();

// int result = SumMainDiagonal(array2d);
// Console.Write(result);

// ___________________________________________________________________

// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{

    int[,] matrix = new int[rows, columns]; // 3x4
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]:F2}, ");
        else
            Console.Write($"{array[i]:F2}");
    }
    Console.Write("]");
}

double[] GetAverageArrayRows(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = (double)sum / matrix.GetLength(1);
    }
    return array;
}

int[,] array2d = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(array2d);


Console.WriteLine();

double[] result = GetAverageArrayRows(array2d);
PrintArray(result);