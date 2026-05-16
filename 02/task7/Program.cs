//Print the first n square numbers
//
int n;
Console.Write("Enter n: ");
int.TryParse(Console.ReadLine(),out n);
for (int i = 1; i <= n; i++)
	Console.WriteLine(i*i);

