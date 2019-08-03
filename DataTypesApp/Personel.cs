namespace DataTypesApp
{
    struct Personel
    {
        public Personel(int sicil, int adet, string marka)
        {
            Sicil = sicil;
            Adet = adet;
            Bilgisayar = new Bilgisayar(marka);
        }
        public int Sicil { get; set; }
        public int Adet { get; set; }
        public Bilgisayar Bilgisayar { get; set; }

        public override string ToString()
        {
            return Sicil + " " + Adet + " " + Bilgisayar.Marka;
        }
    }
}
