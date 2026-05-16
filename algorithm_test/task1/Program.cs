int r,c;
string[] first = Console.ReadLine().Split(' ');
r = int.Parse(first[0]);
c = int.Parse(first[1]);

int[,] records = new int[r, c];
for (int i = 0; i < r; i++)
{
    string[] row = Console.ReadLine().Split(' ');
    for (int j = 0; j < c; j++)
    {
        records[i, j] = int.Parse(row[j]);
    }
}

int eightsCnt = 0;
for (int i = 0; i < r; i++)
    for (int j = 0; j < c; j++)
        if (records[i, j] == 8)
            eightsCnt++;

Console.WriteLine(eightsCnt);
