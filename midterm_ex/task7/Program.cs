int p;
Console.Write("Enter P: ");
int.TryParse(Console.ReadLine(), out p);

int[] numbers = new int[p];

for (int i = 0; i < p; i++)
{
    Console.Write($"Enter {i + 1} number: ");
    int.TryParse(Console.ReadLine(), out numbers[i]);
}

int minind = 0;
int minval = numbers[0];


for (int i = 1; i < p; i++)
{
    if (numbers[i] > minval)
    {
        minval = numbers[i];
        minind = i + 1;
    }
}

Console.WriteLine($"Min value: {minval}, Index (C#): {minind}, Index (Spec): {minind}");






