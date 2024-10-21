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

int GetMinSumOfElements(int[,] matrix)
{
    int sum = 0;
    int sumMin = 0;

    for (int a = 0; a < matrix.GetLength(1); a++)
    {
        sumMin = sumMin + matrix[0, a];
    }

    int i = 0;
    while (i < matrix.GetLength(0))
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];

            if (sumMin > sum)
            {
                sumMin = sum;
            }
        }



    }
    return sumMin;
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();

int result = GetMinSumOfElements(array2d);
Console.WriteLine(result);