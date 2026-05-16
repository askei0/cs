int n;
Console.Write("Enter n: ");
int.TryParse(Console.ReadLine(), out n);

int[] rain = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Enter {i + 1}. rainfall: ");
    int.TryParse(Console.ReadLine(), out rain[i]);
}

int days = 0;

for (int i = 0; i < n; i++)
{
	if ((i == 0 && rain[i] > 0) || (i>0 && rain[i]> rain[i-1]))
	{
		days++;
	}
}

Console.WriteLine($"{days}");


