// Задача 1: Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90]. 
// массив [10 21 14 93 23] => 2




int[] arr = new int[10] { 20, 39, 27, 99, 56, 78, 4, 9, 11, 40 };

int count = 0;

int countNumber = 0;

while (count < arr.Length)
{
    if ((arr[count] >= 10) && (arr[count] <= 90))
    {
        countNumber++;
    }
    count++;
}
Console.WriteLine(countNumber);