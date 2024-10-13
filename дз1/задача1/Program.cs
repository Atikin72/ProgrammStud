Console.Write("Введите первое число: ");
int firstnum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondnum = Convert.ToInt32(Console.ReadLine());

if (secondnum == 0)
{    
    Console.WriteLine("Не ноль делить нельзя");
}
else if (firstnum % secondnum == 0)
{
    Console.WriteLine("Делиться");
}
else
{    
    Console.WriteLine("Не делиться");
}    