class Bicicleta
{
    public string Marca { get; }
    public int An { get; }

    public Bicicleta(string marca, int an)
    {
        Marca = marca;
        An = an;
    }

    public override string ToString()
    {
        return Marca + "(" + An + ")";
    }
}
