// Temp <= 0 - Freezing cold
// Temps > 0 AND <= 10 - Cold
// Temps >= 10 AND <= 15 - Chilly
// Temps >= 15 AND < 20 - Warm
// Temps >= 20 AND < 30 - Hot
// Temp >= 30 - Boiling hot

Console.WriteLine("Enter the temperature:");
int temp = Int32.Parse(Console.ReadLine());

    if (temp >= 30)
    {
        Console.WriteLine("Boiling hot");
    }
    else if (temp < 30 && temp >= 20)
    {
        Console.WriteLine("Hot");
    }
    else if (temp < 20 && temp >= 15)
    {
        Console.WriteLine("Warm");
    } else if (temp < 15 && temp >= 10)
    {
        Console.WriteLine("Chilly");
    } else if (temp < 10 && temp >= 0)
    {
        Console.WriteLine("Cold");
    } else
    {
        Console.WriteLine("Freezing cold");
    }