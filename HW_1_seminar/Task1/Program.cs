// Задание 1 Определите, делится ли число на другое Описание: Напишите метод, который на вход принимает два целых числа и проверяет,
//  делится ли первое число на второе. Если делится, выводите "делится", иначе выводите "не делится".

Console.WriteLine("Введите целое положительное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 == 0)
{
    Console.WriteLine("На ноль нельзя делить!");
}
else if (num1 % num2 == 0)
{
    Console.WriteLine("Число делится");
}
else
{
    Console.WriteLine("Число не делится");
}