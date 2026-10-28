using System;
using System.Collections.Generic;

static partial class Program
{
    static void Sectiune4()
    {
        Console.WriteLine("--- 4.1");
        AdaugaSiSuprascrie();
        Console.WriteLine("--- 4.2");
        CautaCuTryGetValue();
        Console.WriteLine("--- 4.3");
        AdaugaAnaDinNouSiCitesteDan();
        Console.WriteLine("--- 4.4");
        ScoateAnaDeDouaOri();
        Console.WriteLine("--- 4.5");
        DeCeInterfataIDictionary();
    }

    static void AdaugaSiSuprascrie()
    {
        IDictionary<string, int> d = new Dictionary<string, int>();
        d["Ana"] = 9;
        d.Add("Ion", 7);
        d["Ion"] = 10;
        Console.WriteLine(d.Count + " " + d["Ion"]);
    }

    static void CautaCuTryGetValue()
    {
        IDictionary<string, int> d = new Dictionary<string, int> { { "Ana", 9 }, { "Ion", 7 } };
        Console.WriteLine(d.TryGetValue("Dan", out int val) + " " + val);
        Console.WriteLine(d.TryGetValue("Ana", out int val2) + " " + val2);
    }

    static void AdaugaAnaDinNouSiCitesteDan()
    {
        IDictionary<string, int> d = new Dictionary<string, int> { { "Ana", 9 }, { "Ion", 7 } };
        try
        {
            d.Add("Ana", 5);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.GetType().Name);
        }

        try
        {
            d["Dan"] = 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.GetType().Name);
        }
    }

    static void ScoateAnaDeDouaOri()
    {
        IDictionary<string, int> d = new Dictionary<string, int> { { "Ana", 9 }, { "Ion", 7 } };
        Console.WriteLine(d.Remove("Ana"));
        Console.WriteLine(d.Remove("Ana"));
        Console.WriteLine(d.ContainsKey("Ion"));
    }

    static void AfiseazaDictionar(IDictionary<string, int> d)
    {
        Console.WriteLine(string.Join(" ", d));
    }

    static void DeCeInterfataIDictionary()
    {
        IDictionary<string, int> date = new Dictionary<string, int> { { "Zoe", 3 }, { "Ana", 9 }, { "Ion", 7 } };
        AfiseazaDictionar(date);

        date = new SortedDictionary<string, int>(date);
        AfiseazaDictionar(date);

        date = new SortedList<string, int>(date);
        AfiseazaDictionar(date);
    }
}
