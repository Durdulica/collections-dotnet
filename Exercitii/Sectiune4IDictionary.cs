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
    }

    static void CautaCuTryGetValue()
    {
        IDictionary<string, int> d = new Dictionary<string, int> { { "Ana", 9 }, { "Ion", 7 } };
    }

    static void AdaugaAnaDinNouSiCitesteDan()
    {
        IDictionary<string, int> d = new Dictionary<string, int> { { "Ana", 9 }, { "Ion", 7 } };
    }

    static void ScoateAnaDeDouaOri()
    {
        IDictionary<string, int> d = new Dictionary<string, int> { { "Ana", 9 }, { "Ion", 7 } };
    }

    static void DeCeInterfataIDictionary()
    {
        Dictionary<string, int> date = new Dictionary<string, int> { { "Zoe", 3 }, { "Ana", 9 }, { "Ion", 7 } };
    }
}
