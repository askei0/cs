//https://progalap.elte.hu/stuki/v1/?uuid=f343cf05-1eb2-4a6b-a63e-1e03119ba1d5
//https://progalap.elte.hu/specifikacio/v1/?uuid=bb44a2a1-270f-41e6-995a-b56539b61c41

int p;
int.TryParse(Console.ReadLine(), out p);

string[] town = new string[p];
int[] arr = new int[p];
int[] dep = new int[p];

for (int i = 0; i < p; i++)
{
    string[] parts = Console.ReadLine().Split(' ');
    town[i] = parts[0];
    int.TryParse(parts[1], out arr[i]);
    int.TryParse(parts[2], out dep[i]);
}

bool exists = false;
for (int i = 0; i < p; i++)
{
    if (town[i] == "Szekszard" && arr[i] == -1)
    {
        exists = true;
    }
}

if (exists)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");
