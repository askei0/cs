int p;
Console.Write("Enter n: ");
int.TryParse(Console.ReadLine(), out p);

int[] beavers = new int[p];

for (int i = 0; i < p; i++)
{
    Console.Write($"Enter {i + 1}. beaver: ");
    int.TryParse(Console.ReadLine(), out beavers[i]);
}
bool eloc = false;
int j = 0;

while (j < p && beavers[j] > 10)
{
    j++;
}
eloc = (j >= p);
Console.WriteLine($"{eloc}");





