// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.

// “Hello my world” => “world my Hello”





string ReverseWord(string str)
{
    string[] strNewSplit = str.Split();
    string res = string.Empty;
    for (int i = strNewSplit.Length - 1; i >= 0; i--)
    {
        res += strNewSplit[i] + " ";
    }

    return res;
}

string str = "Hello my world";
string res = ReverseWord(str);
Console.WriteLine(res);