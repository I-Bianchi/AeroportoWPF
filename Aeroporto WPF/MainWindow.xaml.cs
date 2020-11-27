using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Aeroporto_WPF.Classi;

namespace Aeroporto_WPF
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Istanzio i generics
            ListaAerei = new List<Aereo>();
            ListaPersone = new List<Persona>();
            ListaAereoporti = new List<Aeroporto>();
            ListaVoli = new List<Volo>();
            ListaBiglietti = new List<Biglietto>();
            InitializeComponent();
        }
        // Dichiaro i generics
        List<Aereo> ListaAerei;
        List<Persona> ListaPersone;
        List<Aeroporto> ListaAereoporti;
        List<Volo> ListaVoli;
        List<Biglietto> ListaBiglietti;



        private void btnCaricamentoDati_Click_1(object sender, RoutedEventArgs e)
        {
            // Creo 5 aerei e li metto in una lista di Aerei
            // Utilizzo un generics, in modo da creare una collezione
            // che contegga oggetti omogenei
            Aereo AE1, AE2, AE3, AE4, AE5;
            AE1 = new Aereo("BOEING", "747", 400, 300, 6, "Motore", true, 900, 1000, "ALITALIA", "BO1ALI");
            AE2 = new Aereo("AIRBUS", "A320", 350, 350, 6, "Motore", true, 1000, 1100, "LUFTHANSA", "AI20LU");
            AE3 = new Aereo("AIRBUS", "A330", 500, 400, 6, "Motore", true, 1100, 1100, "KLM", "KL15AI");
            AE4 = new Aereo("BOEING", "747", 400, 300, 6, "Motore", true, 900, 1000, "KLM", "KL747BO");
            AE5 = new Aereo("BOEING", "737", 300, 300, 4, "Motore", false, 700, 800, "AMERICAN AIRLINES", "BO737AA");
            ListaAerei.Add(AE1);
            ListaAerei.Add(AE2);
            ListaAerei.Add(AE3);
            ListaAerei.Add(AE4);
            ListaAerei.Add(AE5);


            // Creo 5 persone e le metto in una lista di Persona
            // Utilizzo un generics, in modo da creare una collezione
            // che contegga oggetti omogenei

            Persona P1, P2, P3, P4, P5;
            P1 = new Persona("Mario", "Rossi", "Italia", new DateTime(2000, 10, 10), Enumerazioni.Sesso.Maschio, Enumerazioni.TipoDocumento.Passaporto, "AAAA12345", "P01");
            P2 = new Persona("Giuseppe", "Verdi", "Italia", new DateTime(1950, 4, 11), Enumerazioni.Sesso.Maschio, Enumerazioni.TipoDocumento.Passaporto, "AAAA22345", "P02");
            P3 = new Persona("Luigi", "Neri", "Italia", new DateTime(1980, 5, 5), Enumerazioni.Sesso.Maschio, Enumerazioni.TipoDocumento.Passaporto, "BBBB12345", "P03");
            P4 = new Persona("Maria", "Randi", "Italia", new DateTime(1988, 11, 11), Enumerazioni.Sesso.Femmina, Enumerazioni.TipoDocumento.Carta_Identita, "II456578", "P04");
            P5 = new Persona("Mark", "Blackwood", "Inglese", new DateTime(1999, 8, 8), Enumerazioni.Sesso.Maschio, Enumerazioni.TipoDocumento.Passaporto, "HHAA12345", "P05");
            ListaPersone.Add(P1);
            ListaPersone.Add(P2);
            ListaPersone.Add(P3);
            ListaPersone.Add(P4);
            ListaPersone.Add(P5);


            // Creo 5 aereoporti e li metto in una lista di Aereoporti
            // Utilizzo un generics, in modo da creare una collezione
            // che contegga oggetti omogenei

            Aeroporto AP1, AP2, AP3, AP4, AP5;
            AP1 = new Aeroporto("Marconi", "BOM", 30, 40, 20, "Italia", "Bologna", false, false);
            AP2 = new Aeroporto("Malpensa", "MAX", 50, 60, 40, "Italia", "Milano", false, true);
            AP3 = new Aeroporto("John Fitzgerald Kennedy", "JFK", 120, 90, 100, "USA", "New York", false, true);
            AP4 = new Aeroporto("Linate", "LIN", 50, 50, 30, "Italia", "Milano", true, false);
            AP5 = new Aeroporto("Charles De Gaulle", "CDG", 80, 50, 60, "Francia", "Parigi", true, false);
            ListaAereoporti.Add(AP1);
            ListaAereoporti.Add(AP2);
            ListaAereoporti.Add(AP3);
            ListaAereoporti.Add(AP4);
            ListaAereoporti.Add(AP5);

            // Creo 10 Voli e li metto in una lista di Voli
            // Utilizzo un generics, in modo da creare una collezione
            // che contegga oggetti omogenei
            Volo V1, V2, V3, V4, V5, V6, V7, V8, V9, V10;
            V1 = new Volo(new DateTime(2020, 11, 11, 0, 0, 0), new DateTime(2020, 11, 11, 1, 0, 0), "V1", AE1, AP1, 7);
            V2 = new Volo(new DateTime(2020, 11, 12, 0, 30, 0), new DateTime(2020, 11, 12, 1, 30, 0), "V2", AE2, AP3, 40);
            V3 = new Volo(new DateTime(2020, 11, 13, 0, 45, 0), new DateTime(2020, 11, 13, 2, 0, 0), "V3", AE3, AP4, 25);
            V4 = new Volo(new DateTime(2020, 11, 14, 1, 0, 0), new DateTime(2020, 11, 14, 2, 0, 0), "V4", AE2, AP5, 15);
            V5 = new Volo(new DateTime(2020, 11, 15, 2, 0, 0), new DateTime(2020, 11, 15, 3, 30, 0), "V5", AE1, AP5, 8);
            V6 = new Volo(new DateTime(2020, 11, 16, 4, 0, 0), new DateTime(2020, 11, 16, 5, 0, 0), "V6", AE4, AP4, 6);
            V7 = new Volo(new DateTime(2020, 11, 17, 4, 30, 0), new DateTime(2020, 11, 17, 6, 0, 0), "V7", AE5, AP2, 4);
            V8 = new Volo(new DateTime(2020, 11, 18, 6, 0, 0), new DateTime(2020, 11, 18, 7, 30, 0), "V8", AE4, AP1, 7);
            V9 = new Volo(new DateTime(2020, 11, 19, 10, 0, 0), new DateTime(2020, 11, 19, 12, 50, 0), "V9", AE2, AP3, 12);
            V10 = new Volo(new DateTime(2020, 11, 20, 12, 0, 0), new DateTime(2020, 11, 20, 13, 50, 0), "V10", AE1, AP4, 1);
            ListaVoli.Add(V1);
            ListaVoli.Add(V2);
            ListaVoli.Add(V3);
            ListaVoli.Add(V4);
            ListaVoli.Add(V5);
            ListaVoli.Add(V6);
            ListaVoli.Add(V7);
            ListaVoli.Add(V8);
            ListaVoli.Add(V9);
            ListaVoli.Add(V10);

            // Creo 15 Biglietti  e li metto in una lista di Biglietti
            // Utilizzo un generics, in modo da creare una collezione
            // che contegga oggetti omogenei
            Biglietto B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, B11, B12, B13, B14, B15;
            B1 = new Biglietto("B1", V1, P1, Enumerazioni.Ruoli.Pilota, 0, true, Enumerazioni.Sezioni.Nessuna, "");
            B2 = new Biglietto("B2", V1, P2, Enumerazioni.Ruoli.Passeggero, 100, false, Enumerazioni.Sezioni.Seconda, "A16");
            B3 = new Biglietto("B3", V2, P2, Enumerazioni.Ruoli.Steward, 0, true, Enumerazioni.Sezioni.Nessuna, "");
            B4 = new Biglietto("B4", V3, P3, Enumerazioni.Ruoli.Passeggero, 50, false, Enumerazioni.Sezioni.Terza, "A17");
            B5 = new Biglietto("B5", V3, P4, Enumerazioni.Ruoli.Passeggero, 100, false, Enumerazioni.Sezioni.Seconda, "A19");
            B6 = new Biglietto("B6", V3, P5, Enumerazioni.Ruoli.Passeggero, 1000, false, Enumerazioni.Sezioni.Top, "A20");
            B7 = new Biglietto("B7", V4, P5, Enumerazioni.Ruoli.Passeggero, 1500, false, Enumerazioni.Sezioni.Luxury, "A21");
            B8 = new Biglietto("B8", V5, P3, Enumerazioni.Ruoli.Passeggero, 300, false, Enumerazioni.Sezioni.Prima, "A22");
            B9 = new Biglietto("B9", V6, P2, Enumerazioni.Ruoli.Passeggero, 100, false, Enumerazioni.Sezioni.Seconda, "A23");
            B10 = new Biglietto("B10", V7, P2, Enumerazioni.Ruoli.Passeggero, 100, false, Enumerazioni.Sezioni.Seconda, "A24");
            B11 = new Biglietto("B11", V8, P2, Enumerazioni.Ruoli.Passeggero, 50, false, Enumerazioni.Sezioni.Terza, "A25");
            B12 = new Biglietto("B12", V9, P1, Enumerazioni.Ruoli.Passeggero, 300, false, Enumerazioni.Sezioni.Prima, "A26");
            B13 = new Biglietto("B13", V10, P2, Enumerazioni.Ruoli.Passeggero, 2000, false, Enumerazioni.Sezioni.Luxury, "A27");
            B14 = new Biglietto("B14", V10, P4, Enumerazioni.Ruoli.Passeggero, 800, false, Enumerazioni.Sezioni.Business, "A28");
            B15 = new Biglietto("B15", V10, P5, Enumerazioni.Ruoli.Passeggero, 150, false, Enumerazioni.Sezioni.Seconda, "A29");

            ListaBiglietti.Add(B1);
            ListaBiglietti.Add(B2);
            ListaBiglietti.Add(B3);
            ListaBiglietti.Add(B4);
            ListaBiglietti.Add(B5);
            ListaBiglietti.Add(B6);
            ListaBiglietti.Add(B7);
            ListaBiglietti.Add(B8);
            ListaBiglietti.Add(B9);
            ListaBiglietti.Add(B10);
            ListaBiglietti.Add(B11);
            ListaBiglietti.Add(B12);
            ListaBiglietti.Add(B13);
            ListaBiglietti.Add(B14);
            ListaBiglietti.Add(B15);


            MessageBox.Show("Caricamento concluso con successo", "Caricamento dati", MessageBoxButton.OK, MessageBoxImage.Information);
            btnCaricamentoDati.IsEnabled = false;

        }

        private void btnVisualizzaAerei_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (Aereo item in ListaAerei)
            {
                MessageBox.Show(item.CodiceAereo + " " + item.Marca + " " + item.Modello);
            }


        }

        private void btnStatistiche_Click_1(object sender, RoutedEventArgs e)
        {
            Statistiche MieStatistiche = new Statistiche(ListaAerei, ListaPersone, ListaAereoporti, ListaVoli, ListaBiglietti);
            MieStatistiche.Show();
        }
        
    }
}
