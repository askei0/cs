class Program
{
	static void Main()
	{
		//inputs
		string input = Console.ReadLine();
		int n = Convert.ToInt32(input.Split(" ")[0]); // line of inputs
		int t = Convert.ToInt32(input.Split(" ")[1]); // threshold for tasks (b) and (d)
		
		// arr inputs
		string[] names = new string[n];
		string[] resources = new string[n];
		int[] quantities = new int[n];
		double[] energies = new double[n];
		int[] dangers = new int[n];
		// loop for inputs
		for (int i = 0; i < n; i++)
		{
			string[] line = Console.ReadLine().Split(" ");
			names[i] = line[0];
			resources[i] = line[1];
			quantities[i] = Convert.ToInt32(line[2]);
			energies[i] = double.Parse(line[3]);
			dangers[i] = Convert.ToInt32(line[4]);
		}

		// COUNT // task a):
		int cnt = 0;
		for (int i = 0; i < n; i++)
		{
			if (energies[i] < 30.0)
			{
				cnt++;
			}
		}
		Console.WriteLine("Task a):");
		Console.WriteLine(cnt);

		// COUNT // task b):
		int cnt2 = 0;
		for (int i = 0; i < n; i++)
		{
			if (quantities[i] < t)
			{
				cnt2++;
			}
		}
		Console.WriteLine("Task b):");
		Console.WriteLine(cnt2);

		// SUM // task c):
		int kyber = 0;
		int spice = 0;
		int bacta = 0;
		Console.WriteLine("Task c):");
	
		for (int i = 0; i < n; i++)
		{
			if (resources[i] == "Kyber")
			{
				kyber += quantities[i];
			}
			
			if (resources[i] == "Spice")
			{
				spice += quantities[i];
			}
			
			if (resources[i] == "Bacta")
			{
				bacta += quantities[i];
			}
		}
			Console.WriteLine($"Kyber {kyber}");
			Console.WriteLine($"Spice {spice}");
			Console.WriteLine($"Bacta {bacta}");

		// task d):
		
		for (int i = 0; i < n; i++)

		if (name[i])
		

	}


}
