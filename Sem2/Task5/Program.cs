// Напишите программу, которая принимает на вход координаты точки X и Y, причём X ≠ 0 и Y ≠ 0, и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
// Пример:
// X = 2; Y = 3 => 1
// X = -5; Y = 3 => 2
// X = -3; Y = -2 => 3
// X = 4; Y = -2 => 4

Console.WriteLine("Введите X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Координатная четверть плоскости: 1");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Координатная четверть плоскости: 2");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Координатная четверть плоскости: 3");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Координатная четверть плоскости: 4");
}
else
{
    Console.WriteLine("Некорректные координаты!");
}