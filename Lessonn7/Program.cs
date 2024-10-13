// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 100 && num <= 999)
// {
//     int SecondDigit = num / 10 % 10;
//     int ThreeDigit = num % 10;

//     int results = SecondDigit;
//     int coin = 1;

//     while (coin <= ThreeDigit)
//     {
//         results = results * SecondDigit;
//         coin++;
//     }
//     Console.WriteLine(results);
// }
// else
// {
//     Console.WriteLine("Ошибка неверный ввод!");

//_________________________________________________________________

// Console.Write("Введите первое число: ");
// int FerstNum = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int SecondNum = Convert.ToInt32(Console.ReadLine());

// int remalnder = FerstNum % SecondNum;

// if (remalnder == 0)
// {
//     Console.WriteLine("Первое число является делителем второго");
// }
// else
// {
//     Console.WriteLine("Первое число не является делителем второго, " + remalnder);
// }    

//_________________________________________________________________

// Console.Write("Введите число: ");
// int numba = Convert.ToInt32(Console.ReadLine());

// if (numba >= 100 && numba <= 999)
// {
//     int ThreeNumba = numba % 10;
//     Console.WriteLine(ThreeNumba);
// }
// else if (numba >= 1000 && numba <= 9999 )
// {
//     int FourNumba = numba / 10 % 10;
//     Console.WriteLine(FourNumba);
// }
// else
// {
//     Console.WriteLine("Третьего числа нет!");
// }

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 || num <= -100)
{
    while (num > 999 || num < -999)
    {
        num = num / 10;
    }
    int result = num % 10;
    Console.WriteLine("Третья цифра слева " + result);
}
else
{
    Console.WriteLine("Третьей цифры нет ");
}