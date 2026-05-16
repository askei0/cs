
int n;
Console.Write("Enter n: ");
int.TryParse(Console.ReadLine(), out n);

int[] dist = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter {i + 1}. dist: ");
    int.TryParse(Console.ReadLine(), out dist[i]);
}
bool eloc = false;
int j = 0;
while (j < n && dist[j] >= 5)
{ j++; }
eloc = (j >= n);
Console.WriteLine(eloc);
