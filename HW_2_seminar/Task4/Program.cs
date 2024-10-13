// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.
// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

Console.WriteLine("Enter your number");
int enterNumber = Convert.ToInt32(Console.ReadLine());

if (enterNumber < 10)
{
    Console.WriteLine(enterNumber);
}
else
{
    while (enterNumber > 0)
    {
        int remainder = enterNumber % 10;
        enterNumber = enterNumber / 10;
        if (enterNumber > 0)
        {
            Console.Write(remainder + ",");
        }
        else
        {
            Console.Write(remainder);
        }
    }
}