using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "mohammad";
        Dictionary<char, int> counts = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (counts.ContainsKey(c))
                counts[c]++;
            else
                counts[c] = 1;
        }

        foreach (var pair in counts)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
