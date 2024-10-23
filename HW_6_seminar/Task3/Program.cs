// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да



Console.WriteLine("Введите строку, для проверки на полиндром: ");
string polindrom = Console.ReadLine();
for (int i = 0; i < polindrom.Length / 2; i++)
{
    if (polindrom[i] == polindrom[polindrom.Length -1 - i])
    {
        Console.WriteLine("Является полиндромом");
    }
    else
    {
        Console.WriteLine("Не является полиндромом");
        break;
    }
    Console.WriteLine("Является полиндромом");
}
