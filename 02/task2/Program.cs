double a, b, c;

Console.Write("a = "); double.TryParse(Console.ReadLine(), out a);
Console.Write("b = "); double.TryParse(Console.ReadLine(), out b);
Console.Write("c = "); double.TryParse(Console.ReadLine(), out c);

double delta = b * b - 4 * a * c;
bool exists = delta >= 0;

if (exists)
{
    double x = (-b + Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine("x = " + x);
}
else
{
    Console.WriteLine("No real solution");
}



