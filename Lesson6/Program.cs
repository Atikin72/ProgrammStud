// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2 * num2)
// {
//     Console.WriteLine("Первое число является квадратом второго");
// }
// else
// {
//     Console.WriteLine("Первое число не является квадратом второго");
// }

//_________________________________________________________________

//Console.WriteLine("Введите целое положительное число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int count = -num3; //num3 * -1

// while (count <= num3)
// {
//     Console.Write(count + " ");
//     count++; // count = count + 1; count += 1;
// }

//_________________________________________________________________

Console.WriteLine("Введите трезначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999) //if (num > 99 && num < 1000)
{
int firstDigit = num / 100; //456/10=4.56
int lastDigit = num % 10; // 456 % 10=450+6

int result = firstDigit + lastDigit;

Console.WriteLine($"Сумма первой и последней цифры трехзначного числа = {result}");
}
else
{
Console.WriteLine("Ошибка! Число не трехзначное.");
}