int n;
Console.Write("Enter n: ");
int.TryParse(Console.ReadLine(), out n);
int[] trains = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Enter {i + 1}. time: ");
    int.TryParse(Console.ReadLine(), out trains[i]);
}

int ind = 1;
bool eloc;

while (ind <= n && !(trains[ind] < trains[ind - 1]))
{ ind++; }

eloc = (ind < n);
if (eloc == true)
{
    Console.WriteLine($"{ind + 1}. {eloc}");
}
else
{

    Console.WriteLine($"{ind + 1}. false");
}





