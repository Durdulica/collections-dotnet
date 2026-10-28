using System;
using System.Collections.Generic;

static class ExempluIList
{
    public static void Ruleaza()
    {
        IList<string> culori = new List<string> { "rosu", "verde", "albastru" };
        Console.WriteLine("culori[1]: " + culori[1]);
        culori.Insert(1, "galben");
        Console.WriteLine("Dupa Insert(1, galben): " + string.Join(", ", culori));
        Console.WriteLine("IndexOf(albastru): " + culori.IndexOf("albastru"));
        Console.WriteLine("IndexOf(negru): " + culori.IndexOf("negru"));
        culori.RemoveAt(0);
        culori[0] = "mov";
        Console.WriteLine("Dupa RemoveAt(0) si culori[0] = mov: " + string.Join(", ", culori));
        try
        {
            Console.WriteLine(culori[10]);
        }
        catch (Exception e)
        {
            Console.WriteLine("culori[10]: " + e.GetType().Name);
        }

        IList<string> zile = new string[] { "L", "Ma", "Mi" };
        zile[0] = "Luni";
        Console.WriteLine("Tablou dupa zile[0] = Luni: " + string.Join(", ", zile));
        try
        {
            zile.Add("J");
        }
        catch (Exception e)
        {
            Console.WriteLine("Add pe tablou: " + e.GetType().Name);
        }
    }
}
