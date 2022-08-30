using System;

namespace StringUtility;

public static class StringUtility
{
    public static string getTrimmed(this string str)
    {
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
            if(input == null) {
                throw new ArgumentNullException();
            }
            Console.WriteLine("Actual text: \"" + input + "\"");
            Console.WriteLine("After trim: \"" + input.getTrimmed() + "\"");

        }catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}
