using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Prodotto
    {
        public string Nome { get; set; }

        public decimal Prezzo { get; set; }

        public int Quantità { get; set; }

        public double CalcolaTotale(int Prezzo, int Quantità) { return  Prezzo * Quantità; }
    }
}
