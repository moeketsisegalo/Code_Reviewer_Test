using System;
using System.Collections.Generic;

public class NumberConverter
{
    // Arrays to store word representations of units, teens, tens, and thousands
    private static readonly string[] units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    private static readonly string[] teens = { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
    private static readonly string[] tens = { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
    private static readonly string[] thousands = { "", "thousand", "million", "billion", "trillion", "quadrillion", "quintillion", "sextillion", "septillion", "octillion", "nonillion", "decillion" };

    // Function to convert a number to its word representation
    public static string SayNumber(long num)
    {
        if (num == 0)
            return "Zero.";

        // Divide the number into groups of three digits
        List<long> groups = new List<long>();
        while (num > 0)
        {
            groups.Add(num % 1000);
            num /= 1000;
        }

        string result = "";

        // Convert each group of three digits to words
        for (int i = groups.Count - 1; i >= 0; i--)
        {
            long group = groups[i];
            if (group > 0)
                result += SayGroup(group) + " " + thousands[i] + ", ";
        }

        return result.TrimEnd(',', ' ') + ".";
    }

    // Function to convert a three-digit group to words
    private static string SayGroup(long num)
    {
        string result = "";

        // Extract the hundreds digit
        long hundred = num / 100;

        // Extract the tens digit
        long ten = (num / 10) % 10;

        // Extract the units digit
        long unit = num % 10;

        if (hundred > 0)
            result += units[hundred] + " hundred";

        if (ten > 1)
        {
            result += " " + tens[ten];
            if (unit > 0)
                result += "-" + units[unit];
        }
        else if (ten == 1)
        {
            result += " " + teens[unit];
        }
        else if (unit > 0)
        {
            result += " " + units[unit];
        }

        return result.Trim();
    }

    // Main method for testing
    public static void Main(string[] args)
    {
        Console.WriteLine(SayNumber(0));  // Zero.
        Console.WriteLine(SayNumber(12));  // Eleven.
        Console.WriteLine(SayNumber(1043283));  // One million, forty three thousand, two hundred and eighty three.
        Console.WriteLine(SayNumber(90376000010012));  // Ninety trillion, three hundred and seventy six billion, ten thousand and twelve.
    }
}
