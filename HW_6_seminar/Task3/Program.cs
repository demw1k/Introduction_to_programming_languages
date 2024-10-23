

void IsPalindrome(string polindrom)
{
    for (int i = 0; i < polindrom.Length / 2; i++)
    {
        if (polindrom[i] == polindrom[polindrom.Length - 1 - i])
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
}



Console.WriteLine("Введите строку, для проверки на полиндром: ");
string polindrom = Console.ReadLine();
bool isPalindrome = IsPalindrome(polindrom);
Console.WriteLine(isPalindrome ? "Да" : "Нет");