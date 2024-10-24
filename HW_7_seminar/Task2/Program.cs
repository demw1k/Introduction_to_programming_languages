// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

// Псевдокод

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

// int Ackermann(int n, int m)
// {
//     if (n == 0)
//     {
//         return m + 1;
//     }
//     else if (m == 0)
//     {
//         return Ackermann(n - 1, 1);
//     }
//     else
//     {
//         return Ackermann(n - 1, Ackermann(n, m - 1));
//     }
// }

// Console.Write("Введите неотрицательное число M: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите неотрицательное число N: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int res = Ackermann(num1, num2);
// Console.WriteLine($"{res}");

// Второй псевдокод

// функция ack(n, m)
//    пока n ≠ 0
//      если m = 0
//        m:= 1
//      иначе
//        m:= ack(n, m - 1)
//      n:= n - 1
//    вернуть m + 1

int Ackermann(int n, int m)
{
    while (n != 0)
    {
        if (m == 0)
        {
            m = 1;
        }
        else
        {
            m = Ackermann(n, m - 1);

        }
        n = n - 1;
    }
    return m + 1;
}

Console.Write("Введите неотрицательное число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int res = Ackermann(num1, num2);
Console.WriteLine($"{res}");