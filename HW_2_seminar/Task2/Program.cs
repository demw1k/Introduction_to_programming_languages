// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

// 2, 3 => 1
// -5, 3 => 2
// -3, -2 => 3
// 4, -2 => 4

Console.WriteLine("Input first coordinate");
int firstCoordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second coordinate");
int secondCoordinate = Convert.ToInt32(Console.ReadLine());

if (firstCoordinate > 0 && secondCoordinate > 0)
{
    Console.WriteLine("1");
}
else if (firstCoordinate < 0 && secondCoordinate > 0)
{
    Console.WriteLine("2");
}
else if (firstCoordinate < 0 && secondCoordinate < 0)
{
    Console.WriteLine("3");
}
else if (firstCoordinate > 0 && secondCoordinate < 0)
{
    Console.WriteLine("4");
}
else
{
    Console.WriteLine("incorrect data");
}