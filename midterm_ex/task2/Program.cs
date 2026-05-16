bool passed;
int p;
Console.Write("Enter p: ");
int.TryParse(Console.ReadLine(), out p);
int[] scores = new int[p];

for (int i = 0; i < p; i++)
{
    Console.Write($"Enter {i + 1}. score: ");
    int.TryParse(Console.ReadLine(), out scores[i]);
}

int j = 0;

while (j < p && scores[j] >= 50) { j++; }

passed = (j >= p);
Console.WriteLine(passed);








