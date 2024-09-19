// Рекурсия с факториалом 1*2*3*........

// int Fact(int n)
// {
//     if (n==1 || n==0)
//     {
//         Console.WriteLine($"Stop; {n}"); 
//         return 1;
//     }
//     Console.WriteLine(n);
//     return n * Fact(n-1);
// }

// Console.Write(Fact(5));

//_________________________________________________________________

//С раскрученой рекурсией


int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop; {n}");
        return 1;
    }

    Console.WriteLine($"Entering recursion with n = {n}");

    int result = n * Fact(n - 1);

    Console.WriteLine($"Exiting recursion with n = {n}, result = {result}");

    return result;
}

Console.Write(Fact(5));
