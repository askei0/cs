int n;
bool exists;
Console.Write("Enter n: ");
int.TryParse(Console.ReadLine(), out n);
int[] grades = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Enter {i + 1}. grade: ");
    int.TryParse(Console.ReadLine(), out grades[i]);
}

int j = 0;

while (j < n && !(grades[j] < 50))
{
    j++;
}

exists = (j <= n);
if (exists == true)
{
    Console.WriteLine(j + 1);
}
Console.WriteLine(exists);
