// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"



void PrintNaturalNumbers(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m} ");
        if (m == n)
        {
            return;
        }
        PrintNaturalNumbers(m + 1, n);
    }
    else
    {
        Console.Write($"{n} ");
        if (n == m)
        {
            return;
        }
        PrintNaturalNumbers(n + 1, m);
    }
}

Console.Write("Введите натуральное число M: ");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int second_num = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumbers(first_num, second_num);
