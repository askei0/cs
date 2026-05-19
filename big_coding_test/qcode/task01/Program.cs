class Program
{
    static int[,] codeQuality;

    static void Main()
    {
        Console.Write("Enter the number of rows and colomns: ");
        string input = Console.ReadLine();
        int r = Convert.ToInt32(input.Split(" ")[0]);
        int c = Convert.ToInt32(input.Split(" ")[1]);

        codeQuality = new int[r, c];

        for (int i = 0; i < r; i++)
        {
            string input2 = Console.ReadLine();
            for (int j = 0; j < c; j++)
            {
                codeQuality[i, j] = Convert.ToInt32(input2.Split(" ")[j]);
            }
        }

        int perfectBatches = 0;

        for (int i = 0; i < r; i++)
        {
            if (isSeven(ref i, ref c))
                perfectBatches++;
        }

        Console.WriteLine(perfectBatches);
    }

    static bool isSeven(ref int rowIndex, ref int columnLen)
    {
        bool all = true;

        for (int j = 0; j < columnLen; j++)
        {
            if (codeQuality[rowIndex, j] != 7)
            {
                all = false;
                break;
            }
        }
        return all;
    }
}
