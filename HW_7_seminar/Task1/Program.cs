// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"



void PrintNaturalNumbers(int N, int M)
{
    if (N == M - 1) return;
    PrintNaturalNumbers(N - 1, M);
    Console.Write($"{N} ");
}

Console.WriteLine(" Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите натуральное число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(number, number1);
