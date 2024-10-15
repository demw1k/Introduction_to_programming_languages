// Задача 3: Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива.

// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28







double[] arr = { 2.2, 0.4, 9.11, 7.2, 78.98 };

double indMax = arr[0];
double indMin = arr[0];


for (int i = 0; i < arr.Length - 1; i++)
{
    if (indMax > arr[i + 1])
    {

    }
    else
    {
        indMax = arr[i + 1];
    }
}


for (int j = 0; j < arr.Length - 1; j++)
{
    if (indMin < arr[j + 1])
    {

    }
    else
    {
        indMin = arr[j + 1];
    }
}

double result = indMax - indMin;

Console.Write(result);
