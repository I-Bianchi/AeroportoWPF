using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Aeroporto_WPF.Classi.Enumerazioni;

namespace Aeroporto_WPF.Classi
{
    class Aeroporto
    {
        public class Aereoporto
        {
            public string Nome { get; set; }
            public string Sigla { get; set; }
            public int Piste { get; set; }
            public int Terminal { get; set; }
            public double Gates { get; set; }
            public string Nazione { get; set; }
            public string Citta { get; set; }
            public bool Militare { get; set; }
            public bool Internazionale { get; set; }

            public Aereoporto(string Nome, string Sigla, int Piste, int Terminal, double Gates, string Nazione, string Citta, bool Militare, bool Internazionale)
            {
                this.Nome = Nome;
                this.Sigla = Sigla;
                this.Piste = Piste;
                this.Terminal = Terminal;
                this.Gates = Gates;
                this.Nazione = Nazione;
                this.Citta = Citta;
                this.Militare = Militare;
                this.Internazionale = Internazionale;
            }

        }
}
