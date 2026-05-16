int n;
int sayi = 0;
Console.Write("Enter n: ");
int.TryParse(Console.ReadLine(), out n);
int[] miktar = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter {i + 1}: ");
    int.TryParse(Console.ReadLine(), out miktar[i]);
}

for (int i = 0; i < n; i++)
{
    if (miktar[i] == 0)
    {
        sayi++;
    }
}

Console.WriteLine($"Yagis dusmeyen gun sayisi: {sayi}");




