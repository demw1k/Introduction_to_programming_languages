// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные

// “aBcD1ef!-” => “abcd1ef!-”


Console.WriteLine("Задайте строку, содержащую латинские буквы в обоих регистрах.");
string str = Console.ReadLine();
string strResult = string.Empty;

for (int i = 0; i < str.Length; i++)
{
    if (char.IsUpper(str[i]))
    {
        strResult += char.ToLower(str[i]);
    }
    else
    {
        strResult += str[i];
    }
}

Console.WriteLine($" '{str}' => '{strResult}'");