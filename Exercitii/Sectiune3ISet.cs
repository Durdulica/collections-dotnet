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
    }

    static void ReuniuneCuIonSiEva()
    {
        ISet<string> s = new HashSet<string> { "Ana", "Ion", "Maria" };
    }

    static void IntersectieCuIonMariaZoe()
    {
        ISet<string> s = new HashSet<string> { "Ana", "Ion", "Maria" };
    }

    static void ScoateIonSiNumara()
    {
        ISet<string> s = new HashSet<string> { "Ana", "Ion", "Maria" };
    }

    static void DeCeInterfataISet()
    {
        string[] v = { "Ana", "Maria", "Ana", "Dan" };
    }
}
