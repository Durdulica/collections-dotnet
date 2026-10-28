using Exercitii;
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
        c.Add("Ana");
        c.Add("Ion");
        c.Add("Maria");
        c.Add("Ana");
        Console.WriteLine(c.Count);
    }

    static void VerificaContine()
    {
        ICollection<string> c = new List<string> { "Ana", "Ion", "Maria" };
        Console.WriteLine(c.Contains("Ion"));
        Console.WriteLine(c.Contains("Dan"));
    }

    static void ScoateIonSiZoe()
    {
        ICollection<string> c = new List<string> { "Ana", "Ion", "Maria" };
        Console.WriteLine(c.Remove("Ion"));
        Console.WriteLine(c.Remove("Zoe"));
        Console.WriteLine(string.Join(",", c));
        
        /*List<Masina> masini = new List<Masina>();
        masini.Add(new Masina("Dacia", "Logan"));
        masini.Add(new Masina("Dacia", "Duster"));
        masini.Remove(new Masina("Dacia", "Logan"));
        for (int i = 0; i < masini.Count; i++)
        {
            Console.WriteLine(masini[i].Model + " " + masini[i].Marca);
        }*/
    }

    static void GolesteColectia()
    {
        ICollection<string> c = new List<string> { "Ana", "Ion", "Maria" };
        c.Clear();
        Console.WriteLine(c.Count);
    }

    static void Afiseaza(ICollection<int> c)
    {
        Console.WriteLine(c.Count + ": " + string.Join(", ",c));
    }

    static void DeCeInterfataICollection()
    {
        int[] v = { 3, 1, 3, 2 };
        Afiseaza(v);

        ICollection<int> c = new List<int> { 3, 1, 3, 2 };
        Afiseaza(c);
        c = new HashSet<int> { 3, 1, 3, 2 };
        Afiseaza(c);
        c = new LinkedList<int>();
        c.Add(3);
        c.Add(1);
        c.Add(3);
        c.Add(2);
        Afiseaza(c);
    }
}
