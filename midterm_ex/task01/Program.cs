int n;
Console.Write("Enter n: ");
int.TryParse(Console.ReadLine(), out n);

(string isim, int not)[] ogrenci = new (string, int)[n];

for(int i = 0; i<n; i++)
{
	Console.Write($"Enter {i+1}. name: ");
	ogrenci[i].isim = Console.ReadLine();
	Console.Write($"Enter {i+1}. grade: ");
	int.TryParse(Console.ReadLine(), out ogrenci[i].not);
}

int maxind = 0;
int maxval = ogrenci[0].not;

for (int i = 1; i<n; i++)
{
	if(ogrenci[i].not>maxval)
	{
		maxind = i;
		maxval = ogrenci[i].not;
	}
}
string isim = ogrenci[maxind].isim;
Console.WriteLine($"{isim}. {maxval}. {maxind+1}");

