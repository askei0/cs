Console.Write("Enter p: ");
int p;
bool eloc;
int.TryParse(Console.ReadLine(), out p);
int[] temps = new int[p];
for (int i = 0; i < p; i++)
{
    Console.Write($"Enter the {i + 1}. temp: ");
    int.TryParse(Console.ReadLine(), out temps[i]);
}
int j = 0;
while (j < p && temps[j] <= 35)
{
    j++;
}
eloc = (j < p);
Console.WriteLine(eloc);



