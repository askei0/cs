int n;
Console.WriteLine("Enter n: ");
int.TryParse(Console.ReadLine(), out n);

int[] scores = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter {i + 1}. score: ");
    int.TryParse(Console.ReadLine(), out scores[i]);
}
int maxval = scores[0];
int ind = 0;
for (int i = 1; i < n; i++)
{
    if (scores[i] > maxval)
    {
        maxval = scores[i];
        ind = i;
    }
}

Console.WriteLine($"{ind + 1}, {maxval}.");



