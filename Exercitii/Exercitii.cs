using System;
using System.Collections.Generic;

class Elev
{
    public string Nume { get; set; }
    public string Clasa { get; set; }
    public double Medie { get; set; }

    public Elev(string nume, string clasa, double medie)
    {
        Nume = nume;
        Clasa = clasa;
        Medie = medie;
    }
}

class Client
{
    public string Nume { get; set; }
    public int Portii { get; set; }

    public Client(string nume, int portii)
    {
        Nume = nume;
        Portii = portii;
    }
}

static class Exercitii
{
    static List<Elev> Catalog()
    {
        return new List<Elev>
        {
            new Elev("Ana", "12A", 9.50), new Elev("Ion", "11B", 8.20),
            new Elev("Maria", "12A", 9.80), new Elev("Dan", "11B", 9.10),
            new Elev("Ioana", "10C", 7.40), new Elev("Vlad", "10C", 9.50),
            new Elev("Elena", "12A", 4.90)
        };
    }

    public static void Ex0()
    {
    }

    public static void Ex1()
    {
    }

    public static void Ex2()
    {
    }

    public static void Ex3()
    {
    }

    public static void Ex4()
    {
    }

    public static void Ex5()
    {
    }

    public static void Ex6()
    {
    }

    public static void Ex7()
    {
    }

    public static void Ex8()
    {
    }

    public static void Ex9()
    {
    }

    public static void Ex10()
    {
    }
}
