int n;
Console.Write("Enter P: ");
int.TryParse(Console.ReadLine(), out n);

int[] ogruzn = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter {i + 1} number: ");
    int.TryParse(Console.ReadLine(), out ogruzn[i]);
}

int maxind = 0;
int maxval = ogruzn[0];

for (int i = 0; i < n; i++)
{
    if (ogruzn[i] > maxval)
    {
        maxval = ogruzn[i];
        maxind = i;
    }
}
Console.WriteLine($"Max: {maxval}. Max ind: {maxind + 1}");




