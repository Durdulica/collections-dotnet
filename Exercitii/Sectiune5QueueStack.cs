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

        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.Peek());
        Console.WriteLine(q.Count);
    }

    static void StivaPopPeekSiParcurgere()
    {
        Stack<string> s = new Stack<string>();
        s.Push("Ana");
        s.Push("Ion");
        s.Push("Maria");

        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Peek());
        Console.WriteLine(string.Join(", ", s));
    }

    static void ScoateToataCoada()
    {
        Queue<string> q = new Queue<string>();
        q.Enqueue("Ana");
        q.Enqueue("Ion");
        q.Enqueue("Maria");

        while(q.Count > 0)
        {
            Console.WriteLine(q.Dequeue());
        }
    }

    static void ScoateDinGol()
    {
        Queue<string> q = new Queue<string>();
        try
        {
            q.Dequeue();
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.GetType().Name);
        }

        Stack<string> s = new Stack<string>();
        try
        {
            s.Pop();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.GetType().Name);
        }
    }
}
