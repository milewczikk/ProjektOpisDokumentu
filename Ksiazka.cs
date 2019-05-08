using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Ksiazka
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Autor { get; set; }
        public string Wydawnictwo { get; set; }
        public string Gatunek { get; set; }
        public string Seria { get; set; }
        public double Kod { get; set; }
        public string Dostepnosc { get; set; }
    }
}
