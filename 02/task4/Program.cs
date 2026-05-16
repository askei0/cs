int n;

Console.Write("Enter n: ");
int.TryParse(Console.ReadLine(), out n);
int fact = 1;
for (int i = 1; i <= n; i++)
    fact *= i;

Console.WriteLine("Result is: " + fact);
