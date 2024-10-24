// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d


void PrintConsonants(string txt, int index = 0)
{
    if (index == txt.Length)
    {
        return;
    }
    string vowels = "aeiouy";
    if ( char.IsAsciiLetter(txt[index]) && !vowels.Contains(txt[index])) // если без "!" вначале - вернет TRUE, если с ним FALSE, так переворачиваем результат метода
    {
        Console.Write($"{txt[index]}");
    }  
     PrintConsonants(txt, index + 1);
}


Console.WriteLine("Введите строку, содержащую латинские буквы: ");
string text = Console.ReadLine();
PrintConsonants(text);


