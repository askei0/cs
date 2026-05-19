class Program
{
	static void Main(){
		string input = Console.ReadLine();
		int n = Convert.ToInt32(input.Split(" ")[0]);
		int m = Convert.ToInt32(input.Split(" ")[1]);

		int[,] strength = new int[n,m];

		for (int i = 0; i < n; i++)
		{
			string input2 = Console.ReadLine();
			for (int j = 0; j < m; j++)
			{
				strength[i,j] = Convert.ToInt32(input2.Split(" ")[j]);
			}
		}
		
		// task a
		int maxval = strength[0,0];
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < m; j++)
			{
				if (strength[i,j] > maxval)
				{
					maxval = strength[i,j];
				}
			}
		}
		Console.WriteLine($"Task a): \n {maxval}");
		
		// task b
		int cnt = 0;
		for (int i = 0; i < n; i++)
		{
			bool even = false;
			for (int j = 0; j < n; j++)
			{
				if (strength[i,j] % 2 == 0)
				{
					even = true;
					break;
				}
			}
			if(even)
				cnt++;
		}
		Console.WriteLine($"Task b): \n {cnt}");

		// task c

		for (int i = 0; i < n; i++)
		{
			int minval = int.MaxValue;
			for (int j = 0 ; j < m; j++)
			{
				if (strength[i,j] % 2 == 1 && strength[i,j] < minval)
				{
					minval = strength[i,j];
				}
			}
			Console.WriteLine($"{minval} ");
		}



	}


}
