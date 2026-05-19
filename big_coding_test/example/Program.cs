class Program
{
	static void Main()
	{
		string input = Console.ReadLine();
		int n = Convert.ToInt32(input.Split(" ")[0]);
		int w = Convert.ToInt32(input.Split(" ")[1]);
		int p = Convert.ToInt32(input.Split(" ")[2]);

		string[] symbol = new string[n];
		int[,] records = new int[n,w];

		for (int i = 0; i < n; i++)
		{
			string[] line = Console.ReadLine().Split(" ");
			symbol[i] = line[0];
			for (int j = 0; j < w; j++)
			{
				records[i,j] = Convert.ToInt32(line[j + 1]);
			}
		}

		//task a
		bool found = false;
		for (int i = 0; i < n && !found; i++)
		{
			for (int j = 0; j < w; j++)
			{
				if(records[i,j] == p)
				{
					Console.WriteLine($"Task a):");
					Console.WriteLine($"{symbol[i]} {j + 1}");
					found = true;
					break;
				}
			}
		}
		if (!found)
		{
			Console.WriteLine("Task a):");
			Console.WriteLine(-1);
		}

		// task b
		
		int maxDiff = 0;
		int maxDiffIndex = 0;
		for (int i = 0; i < n; i++)
		{
			int smallest = int.MaxValue;
			int biggest = 0;
			for (int j = 0; j < w; j++)
			{
				if (records[i,j] > biggest)
				{
					biggest = records[i,j]; 
				}
				if (records[i,j] < smallest)
				{
					smallest = records[i,j]; 
				}

			}

			int diff = biggest - smallest;
			if (diff > maxDiff)
			{
				maxDiff = diff;
				maxDiffIndex = i;
			}
		}
		Console.WriteLine("Task b): ");
		Console.WriteLine($"{maxDiffIndex + 1} {symbol[maxDiffIndex]}");

		// task c
		
		string[] unique = new string[n];
		double[] sums = new double[n];
		int uniqueCount = 0;

		for (int i = 0; i < n; i++)
		{
		    // bu stock daha once goruldu mu
		    int idx = -1;
		    for (int k = 0; k < uniqueCount; k++)
		    {
		        if (unique[k] == symbol[i])
		        {
		            idx = k;
		            break;
		        }
		    }
		    // gorulmemisse ekle
		    if (idx == -1)
		    {
		        unique[uniqueCount] = symbol[i];
		        idx = uniqueCount;
		        uniqueCount++;
		    }
		    // o stockun toplamina ekle
		    for (int j = 0; j < w; j++)
		        sums[idx] += records[i, j];
		}

		Console.WriteLine("Task c):");
		Console.WriteLine(uniqueCount);
		for (int k = 0; k < uniqueCount; k++)
			Console.WriteLine($"{unique[k]} {sums[k]}");

		// task d
		string[] uniqueD = new string[n];
		int uniqueCountD = 0;

		for (int i = 0; i < n; i++)
		{
		    bool hasOver = false;
		    for (int j = 0; j < w; j++)
		    {
		        if (records[i, j] > p)
		            hasOver = true;
		    }
		    if (hasOver)
		    {
		        // daha once eklendi mi
		        bool alreadyAdded = false;
		        for (int k = 0; k < uniqueCountD; k++)
		        {
		            if (uniqueD[k] == symbol[i])
		            {
		                alreadyAdded = true;
		                break;
		            }
		        }
		        if (!alreadyAdded)
		        {
		            uniqueD[uniqueCountD] = symbol[i];
		            uniqueCountD++;
		        }
		    }
		}

		Console.WriteLine("Task d):");
		Console.WriteLine(uniqueCountD);
		for (int k = 0; k < uniqueCountD; k++)
		    Console.WriteLine(uniqueD[k]);
	}
}
