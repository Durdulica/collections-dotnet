namespace Exercitii
{
    public class Masina
    {
        public string Marca;
        public string Model;

        public Masina(string marca, string model)
        {
            Marca = marca;
            Model = model;
        }

        public override bool Equals(object obj) { 
            Masina m=obj as Masina;
       
            return Marca.Equals(m.Marca);
        }
    }
}
