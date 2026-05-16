int n;
Console.Write("Enter n: ");
int.TryParse(Console.ReadLine(),out n);
(int cm, int m)[] h = new (int, int)[n];

for(int i = 0; i<n; i++)
{
	Console.Write("Enter m: ");
	int.TryParse(Console.ReadLine(),out h[i].m);
	Console.Write("Enter cm: ");
	int.TryParse(Console.ReadLine(),out h[i].cm);
}

int w = 0;
int maxcm = h[0].m*100+h[0].cm;

for(int i = 1; i<n; i++)
{
	if(h[i].m*100+h[i].cm>maxcm)
	{
		maxcm = h[i].m*100+h[i].cm;
		w = i;
	}
}

var maxh=h[w];

Console.WriteLine($"Index: {w+1}. Height {maxh.m}m.{maxh.cm}cm");








