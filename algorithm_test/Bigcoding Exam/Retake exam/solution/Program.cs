/* Yang Kaifa, AJWKHI
This solution was prepared and submitted by the student stated above for the assignment 
of the Programming course. I declare that this solution is my own work. I have not 
copied or used third party solutions. I have not passed my solution to my classmates, 
neither made it public. 
Students’ regulation of Eötvös Loránd University (ELTE Regulations Vol. II. 74/C.§) 
states that as long as a student presents another student’s work - or at least the 
significant part of it - as his/her own performance, it will count as a disciplinary 
fault. The most serious consequence of a disciplinary fault can be dismissal of the 
student from the University.*/

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. declaring (variables, specification: in/out)
            int n;
            int m;
            int[,] pos;

            // task a
            int sumCarWait;

            // task b
            int indLaneFast;

            // task c
            bool existsStrIcr;

            // task d
            int indLaneFewest;

            // 2. reading the input
            string[] firstLine = Console.ReadLine().Split();
            n = int.Parse(firstLine[0]);
            m = int.Parse(firstLine[1]);

            pos = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] iLine = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    pos[i, j] = int.Parse(iLine[j]);
                }
            }

            // 3.a solving the problem of task a
            sumCarWait = 0;
            for (int i = 0; i < n; i++)
            {
                sumCarWait += cntCarPosCol(i, pos);
            }

            // 3.b solving the problem of task b
            indLaneFast = 0;
            int sumCarLeast = sumPassLane(0, pos);
            for (int i = 1; i < n; i++)
            {
                int sumCur = sumPassLane(i, pos);
                if (sumCur < sumCarLeast)
                {
                    indLaneFast = i;
                    sumCarLeast = sumCur;
                }
            }

            // 3.c solving the problem of task c
            int indCur = 0;
            while (indCur < n && !isIcrLane(indCur, pos))
            {
                indCur++;
            }
            existsStrIcr = indCur < n;

            // 3.d solving the problem of task d
            indLaneFewest = 0;
            while (indLaneFewest < n && !(cntSingleLane(indLaneFewest, pos) != 0))
            {
                indLaneFewest++;
            }

            bool existsFewest = indLaneFewest < n;

            if (existsFewest)
            {
                int cntFewest = cntSingleLane(indLaneFewest, pos);
                for (int i = indLaneFewest; i < n; i++)
                {
                    int cntCur = cntSingleLane(i, pos);
                    if (cntCur!= 0 && cntCur < cntFewest)
                    {
                        indLaneFewest = i;
                        cntFewest = cntCur;
                    }
                }
            }

            // 4.a writing the output of task a
            //Console.WriteLine(sumCarWait);

            // 4.b writing the output of task b
            //Console.WriteLine(indLaneFast + 1);

            // 4.c writing the output of task c
            //Console.WriteLine(existsStrIcr);

            // 4.d writing the output of task d
            if (existsFewest)
            {
                Console.WriteLine(indLaneFewest + 1);
            }
            else
            {
                Console.WriteLine(-1);
            }

            // 5.a function of task a
            static int cntCarPosCol(int i, int[,] pos)
            {
                int cnt = 0;
                for (int j = 0; j < pos.GetLength(1); j++)
                {
                    if (pos[i, j] != 0)
                    {
                        cnt++;
                    }
                }
                return cnt;
            }

            // 5.b function of task b
            static int sumPassLane(int i, int[,] pos)
            {
                int sum = 0;
                for (int j = 0; j < pos.GetLength(1); j++)
                {
                    sum += pos[i, j];
                }
                return sum;
            }

            // 5.c function of task c
            static bool isIcrLane(int i, int[,] pos)
            {
                int ind = 0;
                while (ind < pos.GetLength(1) - 1 && pos[i, ind] < pos[i, ind + 1])
                {
                    ind++;
                }
                return ind >= pos.GetLength(1) - 1;
            }

            // 5.d function of task d
            static int cntSingleLane(int i, int[,] pos)
            {
                int cnt = 0;
                for (int j = 0; j < pos.GetLength(1); j++)
                {
                    if (pos[i, j] == 1)
                    {
                        cnt++;
                    }
                }
                return cnt;
            }

        }
    }
}
