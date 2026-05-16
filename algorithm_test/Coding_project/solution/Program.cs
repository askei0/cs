// Specification: https://progalap.elte.hu/specifikacio/v1/?uuid=89615c8d-1cc2-405e-a060-f73990370148
// Algorithm: https://progalap.elte.hu/stuki/v1/?uuid=7be6eb45-767d-4495-96c6-525586516e79
// Name: Yang Kaifa
// Neptun Code: AJWKHI
namespace Train_Schedule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. declaring (variables, specification: in/out)
            int n; // the count of the trains
            int m; // the count of the stations
            int[,] routes; // routes matrix, 1 means train stops at the station and 0 means not
            int[] output; // sequence, 1 means all trains stop and 0 means not all trains stop

            // 2. reading the input
            Console.Error.WriteLine("Number of the trains (n) and staitions (m) seperated by space:");
            string[] numbers = Console.ReadLine().Split();
            n = int.Parse(numbers[0]);
            m = int.Parse(numbers[1]);

            routes = new int[n, m];
            Console.Error.WriteLine("Routes of the trains line by line:");
            for (int i = 0; i < n; i++)
            {
                string[] routesline = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    routes[i, j] = int.Parse(routesline[j]);
                }
            }

            // 3. solving the problem (algorithm)
            output = new int[m];
            for (int j = 0; j < m; j++)
            {
                output[j] = isAllStop(j, n, routes);
            }

            // 4. writing the output
            Console.Write(output[0]);
            for (int j = 1; j < m; j++)
            {
                Console.Write(" " + output[j]);
            }

            // 5. function isAllStop(j, n, routes)
            static int isAllStop(int j, int n, int[,] routes)
            {
                int i = 0;
                while (i < n && routes[i, j] == 1)
                {
                    i++;
                }

                int bit;
                if (i >= n)
                {
                    bit = 1;
                }
                else
                {
                    bit = 0;
                }

                return bit;
            }
        }
    }
}
