// Задание
// Задача 1: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет


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

void IsFindElement(int[,] matrix, int row, int column)
{
    if (matrix.GetLength(0) > row && matrix.GetLength(1) > column)
    {
        Console.WriteLine(matrix[row, column]);
    }
    else
    {
        Console.WriteLine("Нет такого элемента");
    }
}

Console.WriteLine("Введите строку элемента: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец элемента: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(matrix);
IsFindElement(matrix, row, column);
