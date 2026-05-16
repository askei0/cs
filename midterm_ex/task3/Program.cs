int p;
bool rain;
Console.Write("Enter p: ");
int.TryParse(Console.ReadLine(), out p);
int[] rainfall = new int[p];

for (int i = 0; i < p; i++)
{
    Console.WriteLine($"enter {i + 1}. rainfall");
    int.TryParse(Console.ReadLine(), out rainfall[i]);
}

int j = 0;

while (j < p && rainfall[j] != 0)
{ j++; }

rain = (j < p);

Console.WriteLine(rain);



