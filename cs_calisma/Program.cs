// Write a Celsius to Fahrenheit converter.
// The program reads the temperature in Celsius, 
// multiplies the temperature in Celsius by 9/5, 
// and adds 32 to obtain the temperature in Fahrenheit.

Console.WriteLine("Enter the tempreture: ");

float celcius = float.Parse(Console.ReadLine());

float fahrenheit = (celcius * (float)9 / 5) + 32;

Console.WriteLine("Fahrenheit: " + fahrenheit);
