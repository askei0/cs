int n;
Console.Write("Enter n: ");
int.TryParse(Console.ReadLine(),out n);

int[] pushups = new int[n];

for (int i = 0; i<n; i++)
{
	Console.Write($"Enter {i+1}. pushups: ");
	int.TryParse(Console.ReadLine(),out pushups[i]);
}

int cnt = 0;

for(int i = 0; i<n; i++)
{
	if ((i == 0 && pushups[i]>0) || (i > 0 && pushups[i]>pushups[i-1]))
	{
		cnt++;
	}
}
Console.WriteLine($"{cnt}");










