// Задача 2: Задайте двумерный массив. Напишите программу,
//  которая поменяет местами первую и последнюю строку массива.

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
            Console.Write($"{matrix [i,j], 4} "); // , 4 это резерв длины для вывода значения
        }
        Console.WriteLine("|");
    }
    
}

void ChangingArrayRows(int[,]matrix)
{
    int count = 0;
    int firstNum =0;
    while (count < matrix.GetLength(1))
    {
        firstNum = matrix[0,count];
        matrix[0,count] = matrix[matrix.GetLength(0) - 1, count];
        matrix[matrix.GetLength(0) - 1, count] = firstNum;
        count++;
    }
}



int[,] array2d = CreateMatrixRndInt(3,4,1,10);
PrintMatrix(array2d);
Console.WriteLine();
ChangingArrayRows(array2d);
PrintMatrix(array2d);