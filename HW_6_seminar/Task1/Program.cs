// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 

// a b c => “abcdef”
// d e f 



void PrintMatrix(char[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} "); // , 4 это резерв длины для вывода значения
        }
        Console.WriteLine("|");
    }

}

string RowIn2dArray(char[,] charArr)
{
    string res = "";
    for (int i = 0; i < charArr.GetLength(0); i++)
    {
        for (int j = 0; j < charArr.GetLength(1); j++)
        {
            res += charArr[i, j];
        }

    }
    return res;
}

char[,] charArray = new char[,] { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };
PrintMatrix(charArray);
string result = RowIn2dArray(charArray);
Console.WriteLine(result);