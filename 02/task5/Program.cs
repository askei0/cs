//Compute the sum of the divisors of a natural number

Console.Write("Enter a: ");
int a;
int.TryParse(Console.ReadLine(), out a);
int sum = 0;
for (int i = 1; i <= a; i++)
{
    if (a % i == 0 && i % 2 != 0)
        sum += i;
}

Console.WriteLine($"Result is {sum}");

