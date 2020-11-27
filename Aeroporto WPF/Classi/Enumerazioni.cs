using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroporto_WPF.Classi
{
    public class Enumerazioni
    {
        public enum TipoDocumento
        {
            Carta_Identita,
            Patente,
            Passaporto
        }

        public enum Sesso
        {
            Maschio,
            Femmina,
            Altro,
            Non_specifico
        }

        public enum Ruoli
        {
            Passeggero,
            Pilota,
            Copilota,
            Steward,
            Hostess
        }

        public enum Sezioni
        {
            Prima,
            Seconda,
            Terza,
            Economy,
            Business,
            Top,
            Luxury,
            Nessuna
        }
    }
}
