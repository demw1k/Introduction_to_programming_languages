// Задача 4**(не обязательно): Дано натуральное
// число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.

// 425 => [4 2 5]
// 8741 => [8 7 4 1]
// 4 => [4]



Console.WriteLine("Введите число от 1 до 100 000: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num >= 1) && (num <= 100000))
{



    int numCopy = num;
    int count = 0;

    //Считаем кол-во цифр в числе

    while (numCopy != 0)
    {
        numCopy /= 10;
        count++;
    }

    // Cоздаем массив по кол-ву цифр

    int[] arr = new int[count];
    int index = arr.Length -1;
    while (num != 0)
    {
        arr[index] = num % 10;
        num /= 10;
        index--;
    }
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}
else
{
    Console.WriteLine("Введенное число не корректно");
}