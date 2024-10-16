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
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        
        sum = sum + arr[i];

    }
    return sum;
}

int GetProductofElements(int[] arr)
{
    int product = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        
        product = product * arr[i];
    }
    return product;
}


int n = 10;
int[] arr = new int[n];
FillArray(arr);
PrintArray(arr);
int sum1 = GetSumofElements(arr);
int product1 = GetProductofElements(arr);
Console.WriteLine(sum1);
Console.WriteLine(product1);