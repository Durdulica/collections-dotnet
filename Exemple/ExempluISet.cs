using System;
using System.Collections.Generic;

static class ExempluISet
{
    public static void Ruleaza()
    {
        Demo("HashSet", new HashSet<int>());
        Demo("SortedSet", new SortedSet<int>());
    }

    static void Demo(string clasa, ISet<int> numere)
    {
        Console.WriteLine("== " + clasa);
        Console.WriteLine("Add(40): " + numere.Add(40));
        Console.WriteLine("Add(10): " + numere.Add(10));
        Console.WriteLine("Add(40): " + numere.Add(40));
        Console.WriteLine("Add(25): " + numere.Add(25));
        Console.WriteLine("Elemente: " + string.Join(", ", numere));
        Console.WriteLine("Contains(25): " + numere.Contains(25));
        Console.WriteLine("Remove(99): " + numere.Remove(99));
        numere.UnionWith(new[] { 5, 10 });
        Console.WriteLine("Dupa UnionWith(5, 10): " + string.Join(", ", numere));
        numere.IntersectWith(new[] { 5, 25, 70 });
        Console.WriteLine("Dupa IntersectWith(5, 25, 70): " + string.Join(", ", numere));
        numere.ExceptWith(new[] { 5 });
        Console.WriteLine("Dupa ExceptWith(5): " + string.Join(", ", numere));
    }
}
