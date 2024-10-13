        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        PrintOddNumbers(number);
    

    static void PrintOddNumbers(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 != 0) 
            {
                Console.Write($"{i} "); 
            }
        }
        Console.WriteLine();
    }