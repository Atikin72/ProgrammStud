// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в 1 координатной четверти");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Точка находится в 2 координатной четверти");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в 3 координатной четверти");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в 4 координатной четверти");
}
else if(x == 0 || y == 0)
{
    Console.WriteLine("Некоректные координаты");
}