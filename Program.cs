ulong Factorial(int n)
{
    ulong fact = 1;
    for (int i = 1; i <= n; i++)
    {
        fact *= (ulong)i;
    }
    return fact;
}


void PrintArray(int[] array)
{

    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        // Console.Write($"{i}: ");
        Console.Write($"{array[i]}, ");

    }
    Console.WriteLine();
}

void EnumerateAllValue(int[] array, int i, int n)
{

    for (int j = 0; j < n; j++)
    {
        array[i] = j;
        int length = array.Length;

        if (i + 1 < length)
        {
            EnumerateAllValue(array, i + 1, n);
        }
        else
        {
            PrintArray(array);
        }

    }
}

void Perestanovka(int[] array, int i, int n)
{
    int j = 0;
    if (i > 0)
    {
        j = array[i - 1] + 1; ;
    }
    while (j < n)
    {
        array[i] = j;
        int length = array.Length;

        if (i + 1 < length)
        {
            Perestanovka(array, i + 1, n);
        }
        else
        {

            PrintArray(array);
            Thread.Sleep(200);
        }
        j++;
    }
}

// Console.WriteLine("Enter number N:");
// int n = Convert.ToInt32(Console.ReadLine());


int[] cables = { 38, 40, 40, 26, 26, 24, 24, 22, 22, 21, 21, 19,35,65,32,65,43 };

int n = cables.Length;

ulong summOptions = 0;
for (int i = 1; i <= n; i++)
{
    ulong option = Factorial(n) / (Factorial(i) * (Factorial(n - i)));
    summOptions += Factorial(n) / (Factorial(i) * (Factorial(n - i)));
    Console.WriteLine($"Итерация {i} количеств = {option} ИТОГ - {summOptions}");
}
Console.WriteLine($"Количество вариантов для {n} кабелей = {summOptions}");

// for (int i = 1; i <= n; i++)
// {
//     int[] array = new int[i];
//     Perestanovka(array, 0, n);

// }


