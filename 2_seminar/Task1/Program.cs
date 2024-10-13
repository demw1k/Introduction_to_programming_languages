// Задание 1. Совместная работа
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.

Console.WriteLine("Введите целое положительное ТРЁХЗНАЧНОЕ число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;

    int result = firstDigit * 10 + thirdDigit;

    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Некорректный ввод.");
}