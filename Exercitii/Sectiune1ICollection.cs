using System;
using System.Collections.Generic;

static partial class Program
{
    static void Sectiune1()
    {
        Console.WriteLine("--- 1.1");
        AdaugaCuDuplicate();
        Console.WriteLine("--- 1.2");
        VerificaContine();
        Console.WriteLine("--- 1.3");
        ScoateIonSiZoe();
        Console.WriteLine("--- 1.4");
        GolesteColectia();
        Console.WriteLine("--- 1.5");
        DeCeInterfataICollection();
    }

    static void AdaugaCuDuplicate()
    {
        ICollection<string> c = new List<string>();
    }

    static void VerificaContine()
    {
        ICollection<string> c = new List<string> { "Ana", "Ion", "Maria" };
    }

    static void ScoateIonSiZoe()
    {
        ICollection<string> c = new List<string> { "Ana", "Ion", "Maria" };
    }

    static void GolesteColectia()
    {
        ICollection<string> c = new List<string> { "Ana", "Ion", "Maria" };
    }

    static void DeCeInterfataICollection()
    {
        int[] v = { 3, 1, 3, 2 };
    }
}
