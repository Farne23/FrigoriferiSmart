using System;
using System.Collections.Generic;
using System.Text;
using FrigoriferiSmart.Models;

namespace FrigoriferiSmart.Models
{
    class Frigorifero
    {
        List<Prodotto> _prodotti;
        public List<Prodotto> Prodotti { get; set; }

        // Costruttore 
        public Frigorifero()
        {

            Prodotti = new List<Prodotto>();

        }

        //Funzione di inserimento di un prodotto()

        public void AddProdotto(Prodotto nuovo)
        {
            Prodotti.Add(nuovo);
        }
        // Funzione per aggiungere al frigo un prodotto con codice e dati generati casualmente a scopo di test
        public void AddProdottoCASUALE()
        {
            Random random = new Random();
            Prodotto nuovo = new Prodotto(random.Next(0,100000000),"Delizioso e fatto in casa", random.Next(0,300),random.Next(1,29),random.Next(1,13),random.Next(DateTime.Now.Year, DateTime.Now.Year+5));
            Prodotti.Add(nuovo);
        }

        // Funzione per la rimozione di un prodotto
        public string Rimuovi(int xcodice, int xgiorno, int xmese, int xanno)
        {
            DateTime cercascadenza = new DateTime(xanno, xmese, xgiorno);

            for (int i=0; i<Prodotti.Count;i++)
            {
                if (Prodotti[i].Scadenza == cercascadenza && Prodotti[i].Codice== xcodice)
                {
                    //Se viene trovato un prodotto con dati corrispondenti a quelli in input viene stampato e poi rimosso
                    Prodotto Output = Prodotti[i];
                    Prodotti.RemoveAt(i);
                    return $"Prodotto rimosso :\r\n{Output.ToString()}";
                }
            }
           return ("Prodotto non presente");
        }
        
        //Funzione per la stampa di ogni prodotto del frigo
        public override string ToString()
        {
            string output= "Prodotti presenti nel frigo: \r\n \r\n";

            for (int i = 0; i < Prodotti.Count; i++)
            {
                output += $"Prodotto {i} \r\n {Prodotti[i].ToString()}\r\n";
            }

            //La stringa output contiene i dati di tutti i prodotti
            return (output);
        }

        //Funzione per la stampa dei prodotti scaduti nel frigo
        public string Scaduti()
        {
            string output = "Prodotti scaduti nel frigo: \r\n \r\n";

            for (int i = 0; i < Prodotti.Count; i++)
            {
                if(Prodotti[i].Scadenza < DateTime.Now)
                {
                    output += $"Prodotto {i} \r\n {Prodotti[i].ToString()}\r\n";
                }
            }

            if(output != "Prodotti scaduti nel frigo: \r\n \r\n")
            {
                return (output);
            }
            else
            {
                return ("Nessun prodotto scaduto presente");
            }
        }

        public int NConfezioni(int xcodice)
        {
            int n=0;

            for (int i = 0; i < Prodotti.Count; i++)
            {
                if (Prodotti[i].Codice ==  xcodice)
                {
                    n++;
                }
            }

            return (n);
        }

    }
}
