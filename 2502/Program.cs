
Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int oddDivisorsSum = 0;

for (int i = 1; i <= num; i++)
    if (num % i == 0 && i % 2 == 1)
        oddDivisorsSum += i;

Console.WriteLine($"The sum of the odd divisors for {num} is {oddDivisorsSum}");

