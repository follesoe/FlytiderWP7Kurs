namespace Flytider
{
    public class Flyplass
    {
        public string Kode { get; set; }
        public string Navn { get; set; }
        public double Lengdegrad { get; set; }
        public double Breddegrad { get; set; }

        public Flyplass(string kode, string navn, double lengdegrad, double breddegrad)
        {
            Kode = kode;
            Navn = navn;
            Lengdegrad = lengdegrad;
            Breddegrad = breddegrad;
        }

        public override string ToString()
        {
            return Kode + " " + Navn;
        }
    }
}
