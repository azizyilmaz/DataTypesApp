using System;

namespace DataTypesApp
{
    class Takim : ICloneable
    {
        public Takim(int siralama, int puan)
        {
            Siralama = siralama;
            Puan = puan;
        }

        public int Siralama { get; set; }
        public int Puan { get; set; }

        public object Clone()
        {
            return new Takim(Siralama, Puan);
        }

        public override string ToString()
        {
            return "Takım " + Puan + " puan ile " + Siralama + ". sırada";
        }
    }
}
