int n;
Console.Write("Enter n: ");
int.TryParse(Console.ReadLine(), out n);

int[] ws = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter {i + 1}. spell: ");
    int.TryParse(Console.ReadLine(), out ws[i]);
}

int cnt = 0;

for (int i = 0; i < n; i++)
{
    if (i == 1 && ws[i] > 0 || i > 1 && ws[i] > ws[i - 1])
    {
        cnt += 1;
    }
}

Console.WriteLine(cnt);



