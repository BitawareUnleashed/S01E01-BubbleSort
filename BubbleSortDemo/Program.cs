int[] arr = {
    97, 11, 38, 5, 66, 99, 52, 88, 30, 43, 59, 68, 24, 46, 79, 76, 26, 63, 1, 61, 95, 84, 51, 81, 75,
    44, 96, 22, 36, 28, 93, 85, 23, 34, 8, 16, 13, 18, 65, 21, 69, 39, 98, 25, 35, 87, 77, 56, 70, 17,
    86, 91, 50, 60, 54, 71, 47, 74, 33, 37, 89, 92, 62, 31, 64, 78, 67, 20, 32, 2, 72, 90, 55, 45, 83,
    48, 6, 9, 15, 58, 80, 4, 14, 3, 49, 7, 73, 27, 53, 94, 19, 29, 40, 41, 57, 12, 100, 10, 82, 42
};

Console.WriteLine("Array originale:");
PrintArray(arr);
Console.WriteLine("");


int position = 0;
int step = 1;
bool swapped = false;

do
{
    swapped = false;
    for (int j = 0; j < arr.Length - 1; j++)
    {
        if (arr[j] > arr[j + 1])
        {
            // Scambia gli elementi
            Swap(ref arr[j], ref arr[j + 1]);
            swapped = true;
            step++;
            break;
        }
    }
    if (!swapped)
    {
        Console.WriteLine($"Passo {step}: Array ordinato:");
        PrintArray(arr);
    }
    //else
    //{
    //    position = 0;
    //    Console.WriteLine($"Passo {step}: Array parzialmente ordinato:");
    //    PrintArray(arr);
    //}
} while (swapped);



Console.ReadLine();


static void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

static void PrintArray(int[] arr)
{
    foreach (int num in arr)
    {
        Console.Write("[" + num + "] ");
    }
    Console.WriteLine();
}