// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void PrintArray(int[] arr, int i)
{
    Console.Write($"{arr[i]} ");
    if (i == 0) return;
    PrintArray(arr, i - 1);
}

int[] array = { 1, 4, 8, 14, 15, 17, 19 };
PrintArray(array, array.Length - 1);