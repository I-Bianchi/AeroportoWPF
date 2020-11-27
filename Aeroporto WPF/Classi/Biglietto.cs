using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Aeroporto_WPF.Classi.Enumerazioni;

namespace Aeroporto_WPF.Classi
{
    public class Biglietto
    {
        public string Codice { get; set; }
        public Volo VoloBiglietto { get; set; }
        public Persona PersonaBiglietto { get; set; }
        public Ruoli Ruolo { get; set; }
        public double Prezzo { get; set; }
        public bool Elettronico { get; set; }
        public Sezioni Sezione { get; set; }
        public string Posto { get; set; }

        public Biglietto(string Codice, Volo VoloBiglietto, Persona PersonaBiglietto, Ruoli Ruolo, double Prezzo, bool Elettronico, Sezioni Sezione, string Posto)
        {
            this.Codice = Codice;
            this.VoloBiglietto = VoloBiglietto;
            this.PersonaBiglietto = PersonaBiglietto;
            this.Ruolo = Ruolo;
            this.Prezzo = Prezzo;
            this.Elettronico = Elettronico;
            this.Sezione = Sezione;
            this.Posto = Posto;
        }
    }
}
