
Console.WriteLine("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter k: ");
int k = Convert.ToInt32(Console.ReadLine());

int leftApples = k % n;
int applesPerKid = k / n;

Console.WriteLine($"Left apples: {leftApples}. Apples per kid: {applesPerKid}");

