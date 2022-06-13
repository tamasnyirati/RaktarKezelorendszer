using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktarKezeloRendszer
{
    class Tetel
    {
        public string Cikkszam { get; set; }
        public string Megnevezes { get; set; }
        public int Mennyiseg { get; set; }
        public string MennyisegiEgyseg { get; set; }
        public int Ar { get; set; }
        public string BeszallitoNeve { get; set; }
        public string RaktarhelyNeve { get; set; }
        public List<Tetel> Lista;

        public Tetel(string cikkszam, string megnevezes, int mennyiseg, string mennyisegiEgyseg, int ar, string beszallitoNeve, string raktarhelyneve)
        {
            Cikkszam = cikkszam;
            Megnevezes = megnevezes;
            Mennyiseg = mennyiseg;
            MennyisegiEgyseg = mennyisegiEgyseg;
            Ar = ar;
            BeszallitoNeve = beszallitoNeve;
            RaktarhelyNeve = raktarhelyneve;
        }



        public Tetel(List<Tetel> tetelekListaja)
        {
            this.Lista = new List<Tetel>();
        }

        public void teteltListahozad(Tetel tetel)
        {
            Lista.Add(tetel);
        }

        public override string ToString()
        {
            return $"{Cikkszam}, { Megnevezes}, {Mennyiseg}, {MennyisegiEgyseg}, {Ar}, {BeszallitoNeve}, {RaktarhelyNeve}"; 
        }
    }
}
