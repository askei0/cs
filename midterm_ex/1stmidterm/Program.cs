int n;
Console.Write("Enter n: ");
int.TryParse(Console.ReadLine(), out n);
int[] books = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter {i + 1}. book: ");
    int.TryParse(Console.ReadLine(), out books[i]);
}
int j = 0;
bool exists;
while (j < n && !(books[j] > 50))
{
    j++;
}
exists = (j < n);
Console.WriteLine(exists);







