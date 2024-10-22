// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные

// “aBcD1ef!-” => “abcd1ef!-”




string UpperToLower(string str)
{
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

    return strResult;
}

Console.WriteLine("Задайте строку, содержащую латинские буквы в обоих регистрах.");
string str = Console.ReadLine();

string strResult = UpperToLower(str);

Console.WriteLine($" '{str}' => '{strResult}'");