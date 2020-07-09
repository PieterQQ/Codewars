using System;
using System.Linq;

public class Kata
{
    static void Main(string[] args)
    {
        Console.WriteLine(DuplicateCount("Indivisibilities")); 

    }
    public static int DuplicateCount(string str)
    {
     int x= Int32.Parse( str.ToLower().GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count()).Values.Max().ToString());
        return 5;
       
    }
}