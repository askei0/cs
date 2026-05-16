int n;
Console.Write("Enter n: ");
int.TryParse(Console.ReadLine(), out n);
(int m, int cm)[] heights = new (int, int)[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Enter m: ");
    int.TryParse(Console.ReadLine(), out heights[i].m);
    Console.Write("Enter cm: ");
    int.TryParse(Console.ReadLine(), out heights[i].cm);
}

int w = 0;
int maxcm = heights[0].m * 100 + heights[0].cm;
for (int i = 0; i < n; i++)
{
    if (heights[i].m * 100 + heights[i].cm > maxcm)
    {
        maxcm = heights[i].m * 100 + heights[i].cm;
        w = i;
    }
}

var maxh = heights[w];
Console.WriteLine($"Index: {w + 1}, Height: {maxh.m}m {maxh.cm}cm");



