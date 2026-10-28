using System;
using System.Collections.Generic;

static class ExempluIDictionary
{
    public static void Ruleaza()
    {
        Demo("Dictionary", new Dictionary<string, int>());
        Demo("SortedDictionary", new SortedDictionary<string, int>());
        Demo("SortedList", new SortedList<string, int>());
    }

    static void Demo(string clasa, IDictionary<string, int> preturi)
    {
        Console.WriteLine("== " + clasa);
        preturi["paine"] = 4;
        preturi.Add("lapte", 7);
        preturi.Add("ou", 1);
        preturi["paine"] = 5;
        Console.WriteLine("Elemente: " + string.Join(", ", preturi));
        Console.WriteLine("Count: " + preturi.Count + ", paine: " + preturi["paine"]);
        int pret;
        Console.WriteLine("TryGetValue(unt): " + preturi.TryGetValue("unt", out pret) + ", pret = " + pret);
        Console.WriteLine("ContainsKey(ou): " + preturi.ContainsKey("ou"));
        Console.WriteLine("Remove(ou): " + preturi.Remove("ou"));
        try
        {
            preturi.Add("lapte", 8);
        }
        catch (Exception e)
        {
            Console.WriteLine("Add(lapte) a doua oara: " + e.GetType().Name);
        }
        try
        {
            Console.WriteLine(preturi["unt"]);
        }
        catch (Exception e)
        {
            Console.WriteLine("preturi[unt]: " + e.GetType().Name);
        }
    }
}
