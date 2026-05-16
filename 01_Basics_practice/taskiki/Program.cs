// A car consumes "n" liters of petrol on a "k" km long trip (the user gives n and k). 
// Calculate the car's consumption (how many liters it consumes on 100 km).
Console.WriteLine("Enter n: ");
float n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter k: ");
float k = Convert.ToInt32(Console.ReadLine());

float consumption = (n / k) * 100;

Console.WriteLine($"consumption {consumption}");
