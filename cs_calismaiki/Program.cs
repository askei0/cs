// Prepare a converter:
// a) The hour, minute, and second are given -> convert to seconds
// b) The seconds are given -> convert to "hour:minute:second"

Console.WriteLine("If you want to convert hour, minute, and seconds to seconds. Enter 31 on your keyboard. \n if you want to convert seconds to hour:minute:second. Enter 32 on your keyboard. ");

int selection = Convert.ToInt32(Console.ReadLine());

if (selection == 31)
{
    Console.WriteLine("Enter day: ");
    int day = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter hour: ");
    int hour = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Minutes: ");
    int minute = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter seconds: ");
    int seconds = Convert.ToInt32(Console.ReadLine());

    int convertedday = day * 86400;
    int convertedHour = hour * 60;
    int convertedmin = minute * 60;
    int convertedhour2 = convertedHour * 60;
    int finalseconds = convertedday + convertedhour2 + convertedmin + seconds;
    Console.WriteLine(finalseconds + " Seconds");
}
else if (selection == 32)
{
    Console.WriteLine("Enter Seconds: ");
    int seconds = Convert.ToInt32(Console.ReadLine());

    int hours = seconds / 3600;
    int remainingSeconds = seconds % 3600;
    int minutes = remainingSeconds / 60;
    int finalSecs = remainingSeconds % 60;
    Console.WriteLine($"{hours:D2}:{minutes:D2}:{finalSecs:D2}");
}
else
{
    Console.WriteLine("Lutfen 31 ya da 32 giriniz");
}
