//Decide whether a given natural number is a 3-digit number or not

int a;

Console.Write("Enter a: ");

int.TryParse(Console.ReadLine(), out a);

if (100 <= a && a <= 999)
    Console.WriteLine("Its a 3 digit number");
else
    Console.WriteLine("Its not a 3 digit number");
