Console.Write("Enter a number to calculate the sum of its odd divisors: ");
int num = Convert.ToInt32(Console.ReadLine());

int sumOfOddDivisors = 0;

for(int i = 1; i <= num; i++)
	if(i % 2 == 1)
		sumOfOddDivisors = sumOfOddDivisors + i* i;

Console.WriteLine(sumOfOddDivisors);
