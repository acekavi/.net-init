// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for parsing dates from strings

// Collection of various date string formats to attempt parsing
string[] sampleDateTimes = {
    "January 1, 2025 9:30 AM",
    "1/1/2025",
    "Jan 1, 2025 7:30PM",
    "Jan 1, 25",
    "1/2025",
    "1/1 7PM",
    "Jan 1 '15",
};

foreach (string datestr in sampleDateTimes)
{
    if (DateTime.TryParse(datestr, out DateTime result))
    {
        Console.WriteLine($"Parsed date {datestr,-25}: {result}");
    }
    else
    {
        Console.WriteLine($"Failed to parse date: {datestr}");
    }
}
