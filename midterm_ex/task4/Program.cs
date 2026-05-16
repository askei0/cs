//exits ise tersi
int p;
bool higher;
Console.Write("Enter p: ");
int.TryParse(Console.ReadLine(), out p);
int[] grades = new int[p];
for (int i = 0; i < p; i++)
{
    Console.Write($"Enter {i + 1}. grade: ");
    int.TryParse(Console.ReadLine(), out grades[i]);
}

int j = 0;

while (j < p && grades[j] >= 3) { j++; }

higher = (j >= p);

Console.WriteLine(higher);



