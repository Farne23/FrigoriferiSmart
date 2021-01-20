using System;
using FrigoriferiSmart.Models;
using System.Collections.Generic;

namespace FrigoriferiSmart
{
    class Program
    {
        static void Main(string[] args)
        {
            //Versione del programma giá consegnato precedentemente ma con varie correzioni

            //Creo un nuovo prodotto
            Prodotto Latte = new Prodotto(
                97357364,
                "Latte di mucca delizioso",
                42,
                25,
                10,
                2021);
            //Creo un nuovo prodotto scaduto
            Prodotto LatteScaduto = new Prodotto(
                97357364,
                "Latte di mucca delizioso",
                42,
                25,
                10,
                2019);

            // Creo un nuovo oggetto frigorifero



            Frigorifero prova1 = new Frigorifero();

            //Aggiungo prodotti al frigorifero
       
            
            prova1.AddProdotto(Latte);
            prova1.AddProdotto(Latte);
            prova1.AddProdotto(LatteScaduto);

            //Genero prodotti con dati casuali per riempire il frigo
            prova1.AddProdottoCASUALE();
            prova1.AddProdottoCASUALE();
            prova1.AddProdottoCASUALE();
            prova1.AddProdottoCASUALE();
            prova1.AddProdottoCASUALE();
            prova1.AddProdottoCASUALE();

            //Mostro i prodotti nel frigorifero

            Console.WriteLine(prova1);

            //Verifico il numero di confezioni di latte

            int latti = prova1.NConfezioni(97357364);
            Console.WriteLine("Il numero di confezioni di latte e : {0}\r\n",latti.ToString());

            //Verifico la pesenza di prodotti scaduti

            Console.WriteLine(prova1.Scaduti());

            //Qualora fossero presenti prodotti scaduti chiedo all'utente se ha intezione di rimuoverli 
            if(prova1.Scaduti()!= "Nessun prodotto scaduto presente")
            {
                do
                {
                    Console.WriteLine("Desideri rimuovere un prodotto?(S/N)");
                    if (Console.ReadLine() == "S")
                    {
                        //Se l'utente decide di rimuovere un prodotto gli viene data la possibilitá di farlo
                        Console.WriteLine("Inserisci i dati:");
                        Console.WriteLine("Codice:");

                        int cod = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Anno di scadenza:");
                        int ann = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Mese di scadenza:");
                        int mes = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Giorno di scadenza:");
                        int gio = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(prova1.Rimuovi(cod, gio, mes, ann));
                        Console.WriteLine("\r\n");

                    }
                    else
                    {
                        break;
                    }
                } while (true);

                //Mostro nuovamente i prodotti nel frigorifero dopo le operazioni effetuate
                Console.WriteLine("\r\nProdotti scaduti rimasti:\r\n");
                Console.WriteLine(prova1.Scaduti());
                Console.WriteLine("\r\n");
                Console.WriteLine(prova1);
            }

        }
    }
}
