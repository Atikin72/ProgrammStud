Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine("Число положительное");
}
else if (num < 0)
{
    Console.WriteLine("Число отрицательное");
}
else
{
    Console.WriteLine("Ноль");
}    