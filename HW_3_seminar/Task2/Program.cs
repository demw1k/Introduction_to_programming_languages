// Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.

// массив [6 7 19 34 3 1 4 7 9 1] => 3
// массив [1 8 43 4 55 60 3 2 1 3] => 4

int[] arr = new int[10] { 20, 39, 27, 99, 55, 78, 4, 9, 11, 41 };

int count = 0;

int countNumber = 0;

while (count < arr.Length)
{
    if (arr[count] % 2 == 0)
    {
        countNumber++;
    }
    count++;
}
Console.WriteLine(countNumber);