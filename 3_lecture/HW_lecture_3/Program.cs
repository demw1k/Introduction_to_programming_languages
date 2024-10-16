void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = i + 1;
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int GetSumofElements(int[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        int sum = 0;
        int sum = sum + arr[i];

    }
    return sum;
}

// int GetProductofElements(int[] arr)
// {

//     for (int i = 0; i < arr.Length; i++)
//     {
//         product = 1;
//         product = product * arr[i];
//     }
//     return product;
// }


int n = 10;
int[] arr = new int[n];
FillArray(arr);
PrintArray(arr);
int sum = GetSumofElements(arr);
// int product = GetProductofElements(arr);
Console.WriteLine(sum);
// Console.WriteLine(product);