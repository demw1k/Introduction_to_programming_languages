// Считать с консоли строку, состоящую из цифр и латинских букв.
// Сформировать массив, состоящий из цифр этой строки.

// Пример : 

// abc123def06g => [1,2,3,0,6]



string GetLetters(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == false)
        {
            letters = letters + e;
        }
    }
    return letters;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int j = 0; j < arr.Length; j++)
    {
        if (j < arr.Length - 1)
        {
            Console.Write(arr[j] + ",");
        }
        else
        {
            Console.Write(arr[j]);
        }

    }
    Console.Write("]");
}

int[] OutputArray(int[] arr, string result)
{


int result1 = Convert.ToInt32(result);
int result2 = 0;
int i = 0;
while (result1 > 0)
{
    result2 = result1 % 10;
    arr[arr.Length - 1 - i] = result2;
    result1 = result1 / 10;
    i++;
}
return arr;
}


Console.WriteLine("Введите строку из цифр и букв.");
string str = Console.ReadLine();
string result = GetLetters(str);
Console.Write(result + " => ");
int[] arr = { 0, 0, 0 };
OutputArray(arr, result);
PrintArray(arr);



