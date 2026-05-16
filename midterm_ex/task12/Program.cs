int n;
Console.Write("Enter n: ");
int.TryParse(Console.ReadLine(), out n);
(string isim, int boy)[] ogrenci = new (string , int )[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter {i + 1}. name: ");
    ogrenci[i].isim = Console.ReadLine();
    Console.Write($"Enter {i + 1}. heigth: ");
    int.TryParse(Console.ReadLine(), out ogrenci[i].boy);
}

int maxind = 0;
int maxval = ogrenci[0].boy;

for (int i = 1; i < n; i++)
{
    if (ogrenci[i].boy > maxval)
    {
        maxval = ogrenci[i].boy;
        maxind = i;
    }
}

Console.WriteLine($"{ogrenci[maxind].isim}. {maxval}");



