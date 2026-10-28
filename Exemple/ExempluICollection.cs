using System;
using System.Collections.Generic;

static class ExempluICollection
{
    public static void Ruleaza()
    {
        Demo("List", new List<string>());
        Demo("HashSet", new HashSet<string>());
        Demo("LinkedList", new LinkedList<string>());
    }

    static void Demo(string clasa, ICollection<string> orase)
    {
        Console.WriteLine("== " + clasa);
        orase.Add("Cluj");
        orase.Add("Iasi");
        orase.Add("Cluj");
        Console.WriteLine("Count: " + orase.Count);
        Console.WriteLine("Elemente: " + string.Join(", ", orase));
        Console.WriteLine("Contains(Iasi): " + orase.Contains("Iasi"));
        Console.WriteLine("Remove(Oradea): " + orase.Remove("Oradea"));
        Console.WriteLine("Remove(Cluj): " + orase.Remove("Cluj"));
        Console.WriteLine("Elemente: " + string.Join(", ", orase));
        orase.Clear();
        Console.WriteLine("Dupa Clear, Count: " + orase.Count);
    }
}
