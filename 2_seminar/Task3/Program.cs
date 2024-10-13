// Задание 3. Работа в сессионных залах
// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления


Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int result = num % num1;

if (result == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine(result);
}