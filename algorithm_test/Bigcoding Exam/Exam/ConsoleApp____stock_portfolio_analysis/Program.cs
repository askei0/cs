/*Yang Kaifa, AJWKHI
This solution was prepared and submitted by the student stated above for the assignment 
of the Programming course. I declare that this solution is my own work. I have not 
copied or used third party solutions. I have not passed my solution to my classmates, 
neither made it public. 
Students’ regulation of Eötvös Loránd University (ELTE Regulations Vol. II. 74/C.§) 
states that as long as a student presents another student’s work - or at least the 
significant part of it - as his/her own performance, it will count as a disciplinary 
fault. The most serious consequence of a disciplinary fault can be dismissal of the 
student from the University.*/

namespace ConsoleApp____stock_portfolio_analysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. declaring the variables (specification: in/out)
            int n;
            int w;
            double p;
            string[] symb;
            double[,] prices;

            // task a
            string symbOf50;
            int indOfCol50;

            // task b
            int indOfMaxDiff;
            string symbOfMaxDiff;

            // task c
            int cntOfUniqSymb;
            List<string> uniqSymb = new List<string>();
            List<double> sumOfUniqSymb = new List<double>();

            // task d
            int cntOfUniqGreaterP;
            List<string> uniqSymbGreaterP = new List<string>();

            // 2. reading the input
            string[] firstLine = Console.ReadLine().Split();
            n = int.Parse(firstLine[0]);
            w = int.Parse(firstLine[1]);
            p = double.Parse(firstLine[2]);

            symb = new string[n];
            prices = new double[n, w];

            for (int i = 0; i < n; i++)
            {
                string[] wLine = Console.ReadLine().Split();
                symb[i] = wLine[0];
                for (int j = 0; j < w; j++)
                {
                    prices[i, j] = double.Parse(wLine[j + 1]);
                }
            }

            // 3.a solving the problem of task a
            int indOfRow50 = 0;
            while (indOfRow50 < n && !searchCol50(indOfRow50, w, p, prices).exists)
            {
                indOfRow50++;
            }
            bool existsRow50 = indOfRow50 < n;

            symbOf50 = "";
            indOfCol50 = 0;
            if (existsRow50)
            {
                symbOf50 = symb[indOfRow50];
                indOfCol50 = searchCol50(indOfRow50, w, p, prices).ind;
            }

            // 3.b solving the problem of task b
            indOfMaxDiff = 0;
            double maxval = highest(0, w, prices) - lowest(0, w, prices);
            symbOfMaxDiff = symb[0];
            for (int i = 1; i < n; i++)
            {
                double diff = highest(i, w, prices) - lowest(i, w, prices);
                if ((diff - maxval) > 1e-9)
                {
                    indOfMaxDiff = i;
                    maxval = diff;
                    symbOfMaxDiff = symb[i];
                }
            }

            // 3.c solving the problem of task c
            cntOfUniqSymb = 0;
            for (int i = 0; i < n; i++)
            {
                if (isUniqSymb(i, symb))
                {
                    cntOfUniqSymb++;
                    uniqSymb.Add(symb[i]);
                    sumOfUniqSymb.Add(sumOfSymb(i, n, w, symb, prices));
                }
            }

            // 3.d solving the problem of task d
            cntOfUniqGreaterP = 0;
            for (int i = 0; i < n; i++)
            {
                if (isUniqSymb(i, symb) && existsRowGreaterP(i, n, w, p, symb, prices))
                {
                    cntOfUniqGreaterP++;
                    uniqSymbGreaterP.Add(symb[i]);
                }
            }

            // 4.a writing the output of task a
            //if (existsRow50)
            //{
            //    Console.WriteLine(symbOf50 + " " + (indOfCol50 + 1));
            //}
            //else
            //{
            //    Console.WriteLine(-1);
            //}

            // 4.b writing the output of task b
            //Console.WriteLine((indOfMaxDiff + 1) + " " + symbOfMaxDiff);

            // 4.c writing the output of task c
            //Console.WriteLine(cntOfUniqSymb);
            //for (int i = 0; i < cntOfUniqSymb; i++)
            //{
            //    Console.WriteLine(uniqSymb[i] + " " + sumOfUniqSymb[i].ToString("0.################"));
            //}

            // 4.d writing the output of task d
            Console.WriteLine(cntOfUniqGreaterP);
            for (int i = 0; i < cntOfUniqGreaterP; i++)
            {
                Console.WriteLine(uniqSymbGreaterP[i]);
            }

            // 5.a function of task a
            static (bool exists, int ind) searchCol50(int i, int w, double p, double[,] prices)
            {
                bool exists; int ind = 0;
                while (ind < w && !(Math.Abs(prices[i, ind] - p) < 1e-9))
                {
                    ind++;
                }
                exists = ind < w;
                return (exists, ind);
            }

            // 5.b function of task b
            static double highest(int i, int w, double[,] prices)
            {
                double maxval = prices[i, 0];
                for (int j = 1; j < w; j++)
                {
                    if ((prices[i, j] - maxval) > 1e-9)
                    {
                        maxval = prices[i, j];
                    }
                }
                return maxval;
            }

            static double lowest(int i, int w, double[,] prices)
            {
                double minval = prices[i, 0];
                for (int j = 1; j < w; j++)
                {
                    if ((prices[i, j] - minval) < 1e-9)
                    {
                        minval = prices[i, j];
                    }
                }
                return minval;
            }

            // 5.c function of task c
            static bool isUniqSymb(int i, string[] symb) // also used in task d
            {
                int j = 0;
                while (j < i && (symb[j] != symb[i]))
                {
                    j++;
                }
                return j >= i;
            }

            static double sumOfRow(int i, int w, double[,] prices) // used in function sumOfSymb()
            {
                double sum = 0;
                for (int j = 0; j < w; j++)
                {
                    sum += prices[i, j];
                }
                return sum;
            }

            static double sumOfSymb(int i, int n, int w, string[] symb, double[,] prices)
            {
                double sum = 0;
                for (int j = i; j < n; j++)
                {
                    if (symb[j] == symb[i])
                    {
                        sum += sumOfRow(j, w, prices);
                    }
                }
                return sum;
            }

            // 5.d function of task d
            static bool existsColGreaterP(int i, int w, double p, double[,] prices) //used in function existsRowGreaterP()
            {
                int ind = 0;
                while (ind < w && !((prices[i, ind] - p) > 1e-9))
                {
                    ind++;
                }
                bool exists = ind < w;
                return exists;
            }

            static bool existsRowGreaterP(int i, int n, int w, double p, string[] symb, double[,] prices)
            {
                int ind = i;
                while (ind < n && !(symb[ind] == symb[i] && existsColGreaterP(i, w, p, prices)))
                {
                    ind++;
                }
                bool exists = ind < n;
                return exists;
            }
        }
    }
}
