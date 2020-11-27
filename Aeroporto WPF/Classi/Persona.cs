using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Aeroporto_WPF.Classi.Enumerazioni;

namespace Aeroporto_WPF.Classi
{
    class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Nazione { get; set; }
        public DateTime DataNascita { get; set; }
        public Sesso MioSesso { get; set; }
        public TipoDocumento MioDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string CodicePersona { get; set; }

        public Persona(string Nome, string Cognome, string Nazione, DateTime DataNascita, Sesso MioSesso, TipoDocumento MioDocumento, string NumeroDocumento, string CodicePersona)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Nazione = Nazione;
            this.DataNascita = DataNascita;
            this.MioSesso = MioSesso;
            this.MioDocumento = MioDocumento;
            this.NumeroDocumento = NumeroDocumento;
            this.CodicePersona = CodicePersona;
        }


    }
}
