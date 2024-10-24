// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }

    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
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

void GetMinSumOfElements(int[,] matrix)
{

    int sumMin = 0;

    for (int a = 0; a < 1; a++)
    {
        for (int b = 0; b < matrix.GetLength(1); b++)
        {
            sumMin += matrix[a, b];
        }
    }



    int sum = 0;
    int indexOfMin = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < sumMin)
        {
            sumMin = sum;
            indexOfMin = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов - № {indexOfMin + 0}");
}

int[,] array2d = CreateMatrixRndInt(3, 3, 1, 6);
PrintMatrix(array2d);
Console.WriteLine();

GetMinSumOfElements(array2d);
