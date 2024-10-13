// Вывести нечетные числа Описание: Напишите метод, который на вход принимает число (number), 
// а на выходе выводит все нечетные числа от 1 до number (включительно), после каждого числа должен быть знак пробела.

using System.Runtime.CompilerServices;

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= num)
{
    Console.Write(count + " ");
    count = count + 2;
}

