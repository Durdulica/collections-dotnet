using System;
using System.Collections.Generic;

static class ExempluQueueStack
{
    public static void Ruleaza()
    {
        Queue<string> printari = new Queue<string>();
        printari.Enqueue("raport");
        printari.Enqueue("poza");
        printari.Enqueue("bilet");
        Console.WriteLine("Coada: " + string.Join(", ", printari));
        Console.WriteLine("Peek(): " + printari.Peek());
        Console.WriteLine("Dequeue(): " + printari.Dequeue());
        Console.WriteLine("Count: " + printari.Count);

        Stack<string> anulari = new Stack<string>();
        anulari.Push("scrie");
        anulari.Push("sterge");
        anulari.Push("lipeste");
        Console.WriteLine("Stiva (de la varf): " + string.Join(", ", anulari));
        Console.WriteLine("Peek(): " + anulari.Peek());
        Console.WriteLine("Pop(): " + anulari.Pop());
        Console.WriteLine("Count: " + anulari.Count);

        Queue<string> goala = new Queue<string>();
        try
        {
            goala.Dequeue();
        }
        catch (Exception e)
        {
            Console.WriteLine("Dequeue pe coada goala: " + e.GetType().Name);
        }
    }
}
