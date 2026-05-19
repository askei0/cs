internal class Program
{
static int[,] codeQuality;
static void Main(string[] args)
{
Console.Write("Enter the number of rows and columns: ");
string input = Console.ReadLine();
int r =Convert.ToInt32(input.Split(" ")[0]);
int c =Convert.ToInt32(input.Split(" ")[1]);

codeQuality = new int[r, c];

for(int i = 0; i < r; i++)
{
    string input2 = Console.ReadLine();

    for (int j = 0; j < c; j++)
    {
        codeQuality[i,j] =Convert.ToInt32(input2.Split(" ")[j]);
    }
}
//COUNTING
int perfectBatches = 0;

for(int i = 0; i < r; i++)
{
    if (isSeven(ref i, ref c))
        perfectBatches++;
}

Console.WriteLine(perfectBatches);
}
public static bool isSeven(ref int rowIndex, ref int columnLen){

            //DECISION ALL
            int j = 0;
            while (j<columnLen && codeQuality[rowIndex,j] == 7)
                j++;

            bool all = j == columnLen;

            return all;
        
}



}
