int a;
int b;

Console.Write("Enter a: ");
int.TryParse(Console.ReadLine(), out a);

Console.Write("Enter b: ");
int.TryParse(Console.ReadLine(), out b);
if (a > b)
    Console.WriteLine($"{b}");
else
    Console.WriteLine($"{a}");
