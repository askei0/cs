class Program
{
	static void Main()
	{
		string input = Console.ReadLine();
		int r = Convert.ToInt32(input.Split(" ")[0]);
		int c = Convert.ToInt32(input.Split(" ")[1]);

		int[,] records = new int[r,c];

		for (int i = 0; i < r; i++)
		{
			string input2 = Console.ReadLine();
			for (int j = 0; j < c; j++)
			{
				records[i,j] = Convert.ToInt32(input2.Split(" ")[j]);
			}
		}
		int cnt = 0;

		for (int i = 0; i < r; i++)
		{
			for (int j = 0; j < c; j++)
			{
				if (records[i,j] == 8)
				{
					cnt++;
				}
			}
		}
		Console.WriteLine(cnt);
	}
}
