// Задача 1: Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23

// a=50 => нет
// a=7 => нет
// a=322 => да



Console.WriteLine("Input your number");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine("Yes");
    }
else
{
    Console.WriteLine("No");
}