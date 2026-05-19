class Program
{
	static int[,] codeQuality;

	static void Main()
	{
		Console.WriteLine("Enter rows and colomns: ");
		string input = Console.ReadLine();
		int r = Convert.ToInt32(input.Split(" ")[0]);
		int c = Convert.ToInt32(input.Split(" ")[1]);

		codeQuality = new int[r,c];

		for (int i = 0; i < r; i++)
		{
			string input2 = Console.ReadLine();
			for (int j = 0; j < c; j++)
			{
				codeQuality[i, j] = Convert.ToInt32(input2.Split(" ")[j]);
			}
		}
		int perfect = 0;

		for (int i = 0; i < r; i++)
		{
			if(isSeven(ref i, ref c))
				perfect++;
		}
		Console.WriteLine(perfect);
	}

	static bool isSeven(ref int rowIndex, ref int colLen)
	{
		bool all = true;
		for (int i = 0; i < colLen; i++)
		{
			if (codeQuality[rowIndex, i] != 7)
			{
				all = false;
				break;
			}
		}
		return all;
	}









}
