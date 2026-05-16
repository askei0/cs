int n;
int cnt = 0;
Console.Write("Enter n: ");
int.TryParse(Console.ReadLine(),out n);
int[] urun = new int[n];

for (int i = 0; i<n; i++)
{
	Console.Write($"Enter {i+1}: ");
	int.TryParse(Console.ReadLine(), out urun[i]);
}

int j = 0;
int count = 0;

for (;j<n; j++)
{
	if (urun[j]>100){
		cnt++;
	}
}

Console.WriteLine(cnt);  // sonucu yaz


