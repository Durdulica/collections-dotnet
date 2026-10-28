using System;
using System.Collections.Generic;

static partial class Program
{
    static void Sectiune5()
    {
        Console.WriteLine("--- 5.1");
        ServesteUnClient();
        Console.WriteLine("--- 5.2");
        StivaPopPeekSiParcurgere();
        Console.WriteLine("--- 5.3");
        ScoateToataCoada();
        Console.WriteLine("--- 5.4");
        ScoateDinGol();
    }

    static void ServesteUnClient()
    {
        Queue<string> q = new Queue<string>();
        q.Enqueue("Ana");
        q.Enqueue("Ion");
        q.Enqueue("Maria");
    }

    static void StivaPopPeekSiParcurgere()
    {
        Stack<string> s = new Stack<string>();
        s.Push("Ana");
        s.Push("Ion");
        s.Push("Maria");
    }

    static void ScoateToataCoada()
    {
        Queue<string> q = new Queue<string>();
        q.Enqueue("Ana");
        q.Enqueue("Ion");
        q.Enqueue("Maria");
    }

    static void ScoateDinGol()
    {
    }
}
