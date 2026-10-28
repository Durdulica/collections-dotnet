using System;
using System.Collections.Generic;

static partial class Program
{
    static void Sectiune3()
    {
        Console.WriteLine("--- 3.1");
        AdaugaAnaIonAnaMaria();
        Console.WriteLine("--- 3.2");
        ReuniuneCuIonSiEva();
        Console.WriteLine("--- 3.3");
        IntersectieCuIonMariaZoe();
        Console.WriteLine("--- 3.4");
        ScoateIonSiNumara();
        Console.WriteLine("--- 3.5");
        DeCeInterfataISet();
    }

    static void AdaugaAnaIonAnaMaria()
    {
        ISet<string> s = new HashSet<string>();
        Console.WriteLine(s.Add("Ana"));
        Console.WriteLine(s.Add("Ion"));
        Console.WriteLine(s.Add("Ana"));
        Console.WriteLine(s.Add("Maria"));
    }

    static void ReuniuneCuIonSiEva()
    {
        ISet<string> s = new HashSet<string> { "Ana", "Ion", "Maria" };
        ISet<string> s2 = new HashSet<string> { "Ion", "Eva"};
        s.UnionWith(s2);
        Console.WriteLine(string.Join(", ", s));
    }

    static void IntersectieCuIonMariaZoe()
    {
        ISet<string> s = new HashSet<string> { "Ana", "Ion", "Maria" };
        ISet<string> s2 = new HashSet<string> { "Ion", "Maria", "Zoe" };
        s.IntersectWith(s2);
        Console.WriteLine(string.Join(", ", s));
    }

    static void ScoateIonSiNumara()
    {
        ISet<string> s = new HashSet<string> { "Ana", "Ion", "Maria" };
        s.Remove("Ion");
        Console.WriteLine(s.Contains("Ion"));
        Console.WriteLine(s.Count);
    }

    static void AfiseazaMultime(ISet<string> s)
    {
        Console.WriteLine(s.Count + ": " + string.Join(", ", s));
    }

    static void DeCeInterfataISet()
    {
        string[] v = { "Ana", "Maria", "Ana", "Dan" };

        ISet<string> s = new HashSet<string>(v);
        AfiseazaMultime(s);

        s = new SortedSet<string>(v);
        AfiseazaMultime(s);
    }
}
