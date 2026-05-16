//Print the first n square numbers

int n;

Console.Write("Enter n: ");

int.TryParse(Console.ReadLine(), out n);
int i = 2;
while (n % i != 0)
{
    i++;
}
Console.WriteLine(i);

