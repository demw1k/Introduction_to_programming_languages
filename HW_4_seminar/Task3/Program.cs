// Задача 3: Напишите программу, которая перевернёт одномерный массив
//  (первый элемент станет последним, второй – предпоследним и т.д.)

//  [1 3 5 6 7 8] => [8 7 6 5 3 1]

int[] ReverseArray(int[] arr)
{
    
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 -i] = temp;
    }
    return arr;

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
int[] array = { 1, 3, 5, 6, 7, 8 };
PrintArray(array);
ReverseArray(array);
Console.Write(" => ");
PrintArray(array);