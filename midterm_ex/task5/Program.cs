int p;
int sum = 0;
Console.Write("Enter p: ");
int.TryParse(Console.ReadLine(), out p);

int[] numbers = new int[p];

for (int i = 0; i < p; i++)
{
    Console.Write($"Enter {i + 1}. number: ");
    int.TryParse(Console.ReadLine(), out numbers[i]);
}

for (int j = 0; j < p; j++)
{
    sum += numbers[j];
    Console.WriteLine(sum);
}
