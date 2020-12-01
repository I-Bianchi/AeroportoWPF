using Aeroporto_WPF.Classi;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;

namespace Aeroporto_WPF
{
    /// <summary>
    /// Logica di interazione per Statistiche.xaml
    /// </summary>
    public partial class Statistiche : Window
    {





        // Dichiaro le liste all'interno del corpo della classe per averle a disposizione in tutta la classe
        // Le classi relative alle liste devono avere visibilità public

        List<Volo> MieiVoli;
        List<Aereo> MieiAerei;
        List<Persona> MiePersone;
        List<Aeroporto> MieiAereoporti;
        List<Biglietto> MieiBiglietti;


        public Statistiche(List<Aereo> AereiPassati, List<Persona> PersonePassate, List<Aeroporto> AereoportiPassati, List<Volo> VoliPassati, List<Biglietto> BigliettiPassati)
        {
            MieiAerei = AereiPassati;
            MiePersone = PersonePassate;
            MieiAereoporti = AereoportiPassati;
            MieiVoli = VoliPassati;
            MieiBiglietti = BigliettiPassati;

            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Aereo/i con il maggior numero di voli

            // Nella lista MieiVoli ho Voli e Aerei, tutto ciò che mi serve
            // Mi creo una struttura in grado di ospitare gli aerei e i voli da loro eseguiti
            // Inizialmente pongo = 0 il numero dei voli eseguiti per ogni aereo poi man mano che 
            // all'interno della lista MIeiVoli troverò un volo eseguito da un aereo andrò ad
            // incrementare di una unità il numero dei voli di quell'aereo.
            // Uso una HashTable: la chiave è il codice Aereo (non potrà essere duplicato),
            // il valore è il NumeroVoli


            // Dichiaro e inizializzo l'HashTable
            Hashtable ht1 = new Hashtable();
            // Metto a 0 tutti i valori
            foreach (Aereo item in MieiAerei)
            {
                ht1.Add(item.CodiceAereo, 0);
            }
            // Scansiono tutti i Voli, ricavo l'aereo di ogni volo e incremento il suo numero di Voli nella 
            // HashTable
            foreach (Volo item in MieiVoli)
            {
                ht1[item.AereoVolo.CodiceAereo] = Convert.ToInt32(ht1[item.AereoVolo.CodiceAereo]) + 1;
            }

            // Ora eseguo una scansione di tutta la HashTable, determino il valore massimo e poi estraggo
            // tutte le chiavi che hanno il valore massimo

            // Trovo il valore massimo
            int Max = 0;
            foreach (DictionaryEntry item in ht1)
            {
                if (Convert.ToInt32(item.Value) > Max)
                {
                    Max = Convert.ToInt32(item.Value);
                }
            }
            // Scrivo i codici degli aerei con il maggior numero di Voli nell'etichetta
            foreach (DictionaryEntry item in ht1)
            {
                if (Convert.ToInt32(item.Value) == Max)
                {
                    lblAereoPiuVoli.Content = lblAereoPiuVoli.Content + " " + item.Key;
                }
            }

            // Volo/i in cui è presente il maggior numero di passeggeri
            // Dichiaro e inizializzo l'HashTable
            Hashtable ht2 = new Hashtable();
            // Metto a 0 tutti i valori
            foreach (Volo item in MieiVoli)
            {
                ht2.Add(item.Codice, 0);
            }

            // Scansiono tutti i Biglietti, ricavo l'aereo di ogni volo e incremento il suo numero di Voli nella 
            // HashTable
            foreach (Biglietto item in MieiBiglietti)
            {
                if (item.Ruolo == Enumerazioni.Ruoli.Passeggero)
                {
                    ht2[item.VoloBiglietto.Codice] = Convert.ToInt32(ht2[item.VoloBiglietto.Codice]) + 1;
                }
            }


            // Trovo il valore massimo
            int Max2 = 0;
            foreach (DictionaryEntry item in ht2)
            {
                if (Convert.ToInt32(item.Value) > Max2)
                {
                    Max2 = Convert.ToInt32(item.Value);
                }
            }

            // Scrivo i codici dei Voli con il maggior numero di Passeggeri nell'etichetta
            foreach (DictionaryEntry item in ht2)
            {
                if (Convert.ToInt32(item.Value) == Max2)
                {
                    lblVoliPiuPasseggeri.Content = lblVoliPiuPasseggeri.Content + " " + item.Key;
                }
            }

            // Voli arrivati all'aeroporto Marconi

            int MarconiCount = 0;
            foreach (Volo item in MieiVoli)
            {
                if (item.AereoportoVolo.Sigla == "BOM")
                {
                    MarconiCount++;
                }
            }
            lblVoliMarconi.Content = lblVoliMarconi.Content + Convert.ToString(MarconiCount);

            // Voli con pilota a bordo
            int VoliConPilota = 0;

            foreach (Biglietto item in MieiBiglietti)
            {
                if (item.Ruolo == Enumerazioni.Ruoli.Pilota)
                {
                    VoliConPilota++;
                }
            }
            lblVoliConPilota.Content += Convert.ToString(VoliConPilota);

            // Volo/i con maggiore incasso
            // Dichiaro e inizializzo l'HashTable
            Hashtable ht3 = new Hashtable();
            // Metto a 0 tutti i valori
            foreach (Volo item in MieiVoli)
            {
                ht3.Add(item.Codice, 0);
            }

            // Scansiono tutti i Biglietti, ricavo il prezzo di ogni biglietto e
            // incremento il suo valore nella HashTable
            foreach (Biglietto item in MieiBiglietti)
            {
                ht3[item.VoloBiglietto.Codice] = Convert.ToInt32(ht3[item.VoloBiglietto.Codice]) + Convert.ToInt32(item.Prezzo);
            }

            // Trovo il valore massimo
            int Max3 = 0;
            foreach (DictionaryEntry item in ht3)
            {
                if (Convert.ToInt32(item.Value) > Max3)
                {
                    Max3 = Convert.ToInt32(item.Value);
                }
            }


            // Scrivo i codici dei Voli con il maggior incasso nell'etichetta
            foreach (DictionaryEntry item in ht3)
            {
                if (Convert.ToInt32(item.Value) == Max3)
                {
                    lblVoliPiuIncasso.Content = lblVoliPiuIncasso.Content + " " + item.Key;
                }
            }


            //NOME COGNOME CODICEVOLO CODICEBIGLIETTO AEROPORTOARRIVO MARCAAEREO


            List<BigliettiDaPassare> bigliettiDaPassare = new List<BigliettiDaPassare>();

            foreach (Biglietto item in MieiBiglietti)
            {
                bigliettiDaPassare.Add(new BigliettiDaPassare() { Nome = item.PersonaBiglietto.Nome, Cognome = item.PersonaBiglietto.Cognome, CodiceVolo = item.VoloBiglietto.Codice, CodiceBiglietto = item.Codice, CodiceAeroporto = item.VoloBiglietto.AereoportoVolo.Nome, MarcaAereo = item.VoloBiglietto.AereoVolo.Marca });
            }

            lstBiglietti.ItemsSource = bigliettiDaPassare;



        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

    }


}
