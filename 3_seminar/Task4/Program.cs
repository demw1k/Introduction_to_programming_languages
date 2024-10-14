// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м. 
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]







Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int numCopy =num;
int count = 0;

//Считаем кол-во цифр в числе

while (numCopy != 0)
{
    numCopy /= 10;
    count ++;
}

// Cоздаем массив по кол-ву цифр

int [] arr = new int [count];
int index = 0;
while (num != 0)
{
    arr[index] = num % 10;
    num /= 10;
    index++;
}
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}
Console.Write("]");