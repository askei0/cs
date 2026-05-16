
// Read two integer numbers from the user input and print the smaller one

Console.WriteLine("Enter the first integer");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second integer");
int inputS = Convert.ToInt32(Console.ReadLine());

if (input > inputS)
{
    Console.WriteLine(inputS);
}
else
{
    Console.WriteLine(input);
}
