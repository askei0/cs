int n;
Console.Write("Enter n: ");
int.TryParse(Console.ReadLine(), out n);

int[] tickets = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter {i + 1}. ticket: ");
    int.TryParse(Console.ReadLine(), out tickets[i]);
}

bool eloc = false;
int j = 0;

while (j < n && !(tickets[j] < 20))
{
    j++;
}


eloc = (j < n);
if (j == 3)
{
    Console.WriteLine($"{eloc}. ");
}
else
{


    Console.WriteLine($"{eloc}. {j + 1}");
}

