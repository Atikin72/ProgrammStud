Console.Write("Введите натуральное число N: ");
        int number = Convert.ToInt32(Console.ReadLine());

        ShowDigits(number);

    static void ShowDigits(int n)
    {
        // Преобразуем число в строку, чтобы легче было работать с его цифрами
        string numStr = n.ToString();

        // Используем цикл для вывода каждой цифры через запятую
        for (int i = 0; i < numStr.Length; i++)
        {
            if (i == numStr.Length - 1)
            {
                Console.Write(numStr[i]); // Для последней цифры не добавляем запятую
            }
            else
            {
                Console.Write(numStr[i] + ", ");
            }
        }
}