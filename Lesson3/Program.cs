// double CalculeteFormula(int a, int b, int c, int d)
// {
//     double numenator = a * b;
//     int dominator = c + d;
//     double result = numenator / dominator;
//     return result;
// }

// double result = CalculeteFormula(1, 2, 3, 4);
// Console.WriteLine(result);

//  ________________________________________________________________

// double CalculeteFormula2(int a)
// {
//     int squad = a * a;
//    double result = squad;
//     return result;
// }

// double result = CalculeteFormula2(5);
// Console.WriteLine(result);

//  ________________________________________________________________

//void PrintSquad(int limit)
//{
//    int i = 1;
//    while (i <= limit)
//    {
//        Console.Write($"{i * i} ");
//        i++;
//    }
//}

//PrintSquad(10);
//PrintSquad(15);
//PrintSquad(20);
//  ________________________________________________________________

void ZeroEventEvent(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}
void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
ZeroEventEvent(arr);
PrintArray(arr);