// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for formatting date information
using System.Globalization;
// Define a date
DateTime AprFools = new DateTime(2025, 4, 1, 13, 23, 30);

// TODO: 'd' Short date: mm/dd/yyyy (or dd/mm depending on locale)


// TODO: 'D' Full date: mm/dd/yyyy (or dd/mm depending on locale)


// TODO: 'f' Full date, short time


// TODO: 'F' Full date, long time


// TODO: 'g' General date and time


// TODO: 'G' General date and time


// TODO: Format using a specific CultureInfo
Console.WriteLine(AprFools.ToString("d", CultureInfo.CreateSpecificCulture("si-LK")));

// TODO: Defining custom date and time formats
Console.WriteLine($"{AprFools:yyyy/MM/dd}");
Console.WriteLine($"{AprFools:dddd, MMMM, d yyyy}");