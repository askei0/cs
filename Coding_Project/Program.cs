//https://progalap.elte.hu/specifikacio/v1/?uuid=8a8a4f2e-f234-43ff-8de9-ceaddaa3a95a
//https://progalap.elte.hu/stuki/v1/?uuid=40847d12-363c-4f27-ab05-12d1aeac7714
string[] first = Console.ReadLine().Split(' ');
int stno = int.Parse(first[0]);
int suno = int.Parse(first[1]);

int[,] results = new int[stno, suno];
for (int i = 0; i < stno; i++)
{
    string[] row = Console.ReadLine().Split(' ');
    for (int j = 0; j < suno; j++)
        results[i, j] = int.Parse(row[j]);
}

// passed(row) = COUNT
int[] passed = new int[stno];
for (int i = 0; i < stno; i++)
{
    passed[i] = 0;
    for (int j = 0; j < suno; j++)
        if (results[i, j] > 25)
            passed[i]++;
}

// MIS
int manyexamsno = 0;
List<int> manyexamsindexes = new List<int>();
for (int i = 0; i < stno; i++)
{
    if (passed[i] > 2)
    {
        manyexamsno++;
        manyexamsindexes.Add(i + 1);
    }
}

Console.Write(manyexamsno);
foreach (int idx in manyexamsindexes)
    Console.Write(" " + idx);
Console.WriteLine();