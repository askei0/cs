Console.WriteLine("Enter a number");
int natural = Convert.ToInt32(Console.ReadLine());

int sumOfSquare = 0;
for (int i = 1; i <= natural; i++)
    sumOfSquare += i * i;

Console.WriteLine(sumOfSquare);

