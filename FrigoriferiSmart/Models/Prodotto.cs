using System;
using System.Collections.Generic;
using System.Text;
using FrigoriferiSmart.Models;

namespace FrigoriferiSmart.Models
{
    class Prodotto
    {
        int _codice;
        string _descrizione;
        DateTime _scadenza; 
        int _calorie;

        // Campi puibblici
        public int Codice { get; private set; }
        public string Descrizione { get; private set; }
        public DateTime Scadenza { get; private set; }
        public int Calorie { get; private set; }

        //Costruttore con valori
        public Prodotto(int xcodice, string xdescrizione, int xcalorie, int xgiorno, int xmese, int xanno  )
        {
            Codice = xcodice;
            Descrizione = xdescrizione;
            Calorie = xcalorie;
            Scadenza = new DateTime(xanno, xmese, xgiorno);
        }
        //Costruttore senza valori
        public Prodotto()
        {
            Codice = 0;
            Descrizione = "";
            Calorie = 0;
            Scadenza = new DateTime();
        }

        //Ovveride di ToString() per stampare i dati del prodotto
        public override string ToString()
        {

            return $"--------------------------------- \r\n Codice: {Codice} \r\n Descrizione: {Descrizione} \r\n Calorie: {Calorie} \r\n Data di scadenza: {Scadenza.ToString("dd/MM/yyyy")} \r\n --------------------------------- ";
        }


    }
}
