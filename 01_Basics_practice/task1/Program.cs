Console.WriteLine("Enter the length: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the width: ");
int width = Convert.ToInt32(Console.ReadLine());

float area = length * width;
float perimeter = 2 * (length + width);

Console.WriteLine("Area = " + area + " Perimeter = " + perimeter);

