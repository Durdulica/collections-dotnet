using System;
using System.Collections.Generic;

static partial class Program
{
    static void Sectiune6()
    {
        Console.WriteLine("--- 6.1");
        SituatiaVizitatori();
        Console.WriteLine("--- 6.2");
        SituatiaIstoric();
        Console.WriteLine("--- 6.3");
        SituatiaTelefoane();
        Console.WriteLine("--- 6.4");
        SituatiaTemperaturi();
        Console.WriteLine("--- 6.5");
        SituatiaGhiseu();
        Console.WriteLine("--- 6.6");
        SituatiaNumere();
        Console.WriteLine("--- 6.7");
        SituatiaNote();
        Console.WriteLine("--- 6.8");
        SituatiaScoruri();
        Console.WriteLine("--- 6.9");
        SituatiaMetrou();
        Console.WriteLine("--- 6.10");
        SituatiaClasament();
    }

    static void SituatiaVizitatori() //HashSet
    {
        ISet<string> c = new HashSet<string>();
        c.Add("Ana");
        c.Add("Ion");
        c.Add("Ana");
        c.Add("Maria");
        c.Add("Ion");
        Console.WriteLine(c.Count);
    }

    static void SituatiaIstoric() //Stack
    {
        Stack<char> s = new Stack<char>();
        s.Push('A');
        s.Push('B');
        s.Push('C');
        Console.WriteLine(s.Pop() + " " + s.Pop() + " " + s.Peek());
    }

    static void SituatiaTelefoane()  //Dictionary
    {
        Dictionary<string, string> d = new Dictionary<string, string>();
        d.Add("Ana", "0711");
        d.Add("Ion", "0722");
        
        if(d.TryGetValue("Ion", out string tel))
        {
            Console.Write(tel + " ");
        }
        else
        {
            Console.Write("lipsa ");
        }

        if (d.TryGetValue("Dan", out string tel2))
        {
            Console.WriteLine(tel2);
        }
        else
        {
            Console.WriteLine("lipsa");
        }
    }

    static void SituatiaTemperaturi() //List
    {
        List<int> l = new List<int> { 12, 8, 15, 9, 11 };
        l.Sort();
        Console.WriteLine(string.Join(", ", l) + " " + l.IndexOf(15));
    }

    static void SituatiaGhiseu() //Queue
    {
        Queue<string> q = new Queue<string>();
        q.Enqueue("Ana");
        q.Enqueue("Ion");
        q.Enqueue("Maria");
        Console.WriteLine(q.Dequeue() + " " + q.Dequeue());
    }

    static void SituatiaNumere() //SortedSet
    {
        SortedSet<int> c = new SortedSet<int> { 5, 3, 8, 3, 1 };
        Console.WriteLine(c.Min + " " + c.Max + ", sortat: " + string.Join(", ", c));
    }

    static void SituatiaNote() //List
    {
        List<int> l = new List<int> { 9, 6, 10, 7 };
        l[1] = 8;
        l.RemoveAt(3);
        l.Sort();
        Console.WriteLine(string.Join(", ", l));
    }

    static void SituatiaScoruri() //SortedDictionary
    {
        SortedDictionary<string, int> d = new SortedDictionary<string, int>();
        d.Add("Zoe", 5);
        d.Add("Ana", 9);
        d.Add("Ion", 7);
        Console.WriteLine(string.Join(", ", d));
    }

    static void SituatiaMetrou() //LinkedList
    {
        LinkedList<string> l = new LinkedList<string>();
        l.AddLast("Ion");
        l.AddLast("Maria");
        l.AddFirst("Ana");
        l.AddLast("Dan");
        l.RemoveLast();
        Console.WriteLine(string.Join(", ", l));
    }

    static void SituatiaClasament() //SortedList
    {
        SortedList<string, int> d = new SortedList<string, int>();
        d.Add("Zoe", 5);
        d.Add("Ana", 9);
        d.Add("Ion", 7);
        foreach (KeyValuePair<string, int> kv in d) 
        {
            Console.WriteLine(kv.Key + " = " + kv.Value);
        }
    }
}
