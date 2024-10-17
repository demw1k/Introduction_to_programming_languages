// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [344 452 341 125] => 2

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 999);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

int SumEvenNumber(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}


int[] arr = CreateArrayRndInt(5);
PrintArray(arr);

int result = SumEvenNumber(arr);       // Эти 2 строки можно записать так, но не рекомендуется
Console.WriteLine($" => {result}"); 

