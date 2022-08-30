using System;

namespace StringUtility;

public static class StringUtility
{

    /// <exception cref="NullReferenceException">
    /// Thrown when the string passed is null.
    /// </exception>
    /// <summary>
    /// This method removes whitespaces from a string
    /// </summary>
    /// <param name="str">this string</param>
    /// <returns>
    /// A string without whitespaces.
    /// </returns>
    public static string getTrimmed(this string str)
    {
        if (str == null)
        {
            throw new NullReferenceException();
        }
        return str.Trim();
    }
}

public class Program
{

    public static void Main(string[] args)
    {

        try
        {
            string? input = Console.ReadLine();
            if (input == null)
            {
                throw new NullReferenceException();
            }
            Console.WriteLine("Actual text: \"" + input + "\"");
            Console.WriteLine("After trim: \"" + input.getTrimmed() + "\"");

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
