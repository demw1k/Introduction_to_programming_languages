// Задание 2 Поиск среднего из трех чисел Описание: Напишите метод, который принимает 
// на вход три числа и возвращает среднее из этих чисел (то есть не самое большое и не самое маленькое).

Console.WriteLine("Введите целое положительное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if ((num1 >= num2 && num1 <= num3) || (num1 >= num3 && num1 <= num2))
{
    Console.WriteLine(num1);
}
else if ((num2 >= num1 && num1 <= num3) || (num2 >= num3 && num2 <= num1))
{
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine(num3);
}