class Elev
{
    public string Nume { get; }
    public int Nota { get; }

    public Elev(string nume, int nota)
    {
        Nume = nume;
        Nota = nota;
    }

    public override string ToString()
    {
        return Nume + "(" + Nota + ")";
    }
}
