// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 40 => 4
// 96 => 9
// 72 => 7


Console.WriteLine("Enter a number from 10 to 99");
int enterNumber = Convert.ToInt32(Console.ReadLine());

if (enterNumber >= 10 && enterNumber <= 99)
{
    int num1 = enterNumber / 10;
    int num2 = enterNumber % 10;
    if (num1 > num2)
    {
        Console.WriteLine(num1);
    }
    else if (num1 < num2)
    {
        Console.WriteLine(num2);
    }
    else if (num1 == num2)
    {
        Console.WriteLine(num1);
    }
}
else
{
    Console.WriteLine("the number was entered incorrectly");
}