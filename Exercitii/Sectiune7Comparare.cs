using System;
using System.Collections.Generic;

static partial class Program
{
    static void Sectiune7()
    {
        Console.WriteLine("--- 7.1");
        FaElevulComparabil();
        Console.WriteLine("--- 7.2");
        SortedSetAreNevoieDeComparabil();
        Console.WriteLine("--- 7.3");
        ComparerDupaNume();
        Console.WriteLine("--- 7.4");
        ComparerDupaNotaDescrescator();
        Console.WriteLine("--- 7.5");
        SortedDictionaryCuComparer();
        Console.WriteLine("--- 7.6");
        CompareToEgalInseamnaDuplicat();
    }

    static void FaElevulComparabil()
    {
        List<Elev> lista = new List<Elev> { new Elev("Ana", 9), new Elev("Ion", 6), new Elev("Maria", 10), new Elev("Dan", 7) };
    }

    static void SortedSetAreNevoieDeComparabil()
    {
        List<Elev> elevi = new List<Elev> { new Elev("Ana", 9), new Elev("Ion", 6), new Elev("Maria", 10), new Elev("Dan", 7) };
        Bicicleta pegas = new Bicicleta("Pegas", 2015);
        Bicicleta cube = new Bicicleta("Cube", 2018);
    }

    static void ComparerDupaNume()
    {
        List<Elev> lista = new List<Elev> { new Elev("Ana", 9), new Elev("Ion", 6), new Elev("Maria", 10), new Elev("Dan", 7) };
    }

    static void ComparerDupaNotaDescrescator()
    {
        List<Elev> lista = new List<Elev> { new Elev("Ana", 9), new Elev("Ion", 6), new Elev("Maria", 10), new Elev("Dan", 7) };
    }

    static void SortedDictionaryCuComparer()
    {
        string[] chei = { "paine", "ou", "lapte", "unt" };
    }

    static void CompareToEgalInseamnaDuplicat()
    {
        Elev ana = new Elev("Ana", 9);
        Elev vlad = new Elev("Vlad", 9);
    }
}
