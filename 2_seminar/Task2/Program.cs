// Задание 2. Работа в сессионных залах
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.

using System.Reflection;

Console.WriteLine("Введите целое положительное ТРЁХЗНАЧНОЕ число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int secondDigit = num / 10 % 10;
    int thirdDigit = num % 10;

    int result = secondDigit;

    for (int i = 1; i < thirdDigit; i++)
    {
        result = result * secondDigit; // result *= secondDigit
    }
    Console.WriteLine(result);
}
else Console.WriteLine("Некорректный ввод.");

// ИЛИ ЧЕРЕЗ ЦИКЛ WHILE

// int count = 1; // вводим счетчик

// while (count < thirdDigit)
// {
//     result = result * secondDigit;
//     count++;
// }