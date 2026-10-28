using System;
using System.Collections.Generic;

static partial class Program
{
    static void Sectiune2()
    {
        Console.WriteLine("--- 2.1");
        PuneDanPePrimaPozitie();
        Console.WriteLine("--- 2.2");
        PozitiaLuiMariaSiZoe();
        Console.WriteLine("--- 2.3");
        InlocuiesteIonCuEvaSiScoatePrimul();
        Console.WriteLine("--- 2.4");
        CitesteDupaUltimaPozitie();
        Console.WriteLine("--- 2.5");
        DeCeInterfataIList();
    }

    static void PuneDanPePrimaPozitie()
    {
        IList<string> l = new List<string> { "Ana", "Ion", "Maria" };
        l.Insert(0, "Dan");
        Console.WriteLine(string.Join(", ", l));
    }

    static void PozitiaLuiMariaSiZoe()
    {
        IList<string> l = new List<string> { "Ana", "Ion", "Maria" };
        Console.WriteLine(l.IndexOf("Maria"));
        Console.WriteLine(l.IndexOf("Zoe"));
    }

    static void InlocuiesteIonCuEvaSiScoatePrimul()
    {
        IList<string> l = new List<string> { "Ana", "Ion", "Maria" };
        l[1] = "Eva";
        l.RemoveAt(0);
        Console.WriteLine(string.Join (", ", l));
    }

    static void CitesteDupaUltimaPozitie()
    {
        IList<string> l = new List<string> { "Ana", "Ion", "Maria" };
        try
        {
            Console.WriteLine(l[3]);
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.GetType().Name);
        }
    }

    static void Mareste(IList<int> l)
    {
        l.Add(4);
        Console.WriteLine(string.Join(", ", l));
    }

    static void Schimba(IList<int> l)
    {
        l[0] = 9;
        Console.WriteLine(string.Join(", ", l));
    }

    static void DeCeInterfataIList()
    {
        List<int> l = new List<int>() { 1, 2, 3 };
        int[] v = l.ToArray();

        Mareste(l);
        Schimba(l);
        try
        {
            Mareste(v);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.GetType().Name);
        }
        Schimba(v);
    }
}
