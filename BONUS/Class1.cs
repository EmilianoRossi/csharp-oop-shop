using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BONUS
{
    internal class Class1
    {


        //---------- DICHIARO LE VARIABILI --------------
        private int codiceProdotto;
        private string nomeProdotto;
        private string descrizione;
        private double prezzo;
        private string iva;
        private int numero;

        //---------- COSTRUTTORE --------------
        public Class1(string nomeProdotto, string descrizione, double prezzo, string iva)
        {

            this.nomeProdotto = nomeProdotto;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;

        }

        //-------------- METODO 1 CREAZIONE CODICE -------------

        public int GetGeneraCodiceProdotto()
        {

            Random random = new Random();
            int numero = random.Next(100);
            this.numero = numero;
            return numero;


        }

        //------------ METODO 2 CALCOLA PREZZO CON IVA ------------

        public double GetCalcolaPrezzoIva()
        {

            double prezzoConIva = prezzo * 1.22;
            return prezzoConIva;

        }

        //----------- METODO 3 STAMPA NOME ESTESO ----------
        public string GetNomeEsteso()
        {

            string nomePiuCodice = nomeProdotto + " ID: " + GetGeneraCodiceProdotto();
            return nomePiuCodice;

        }

        //------------ METODO 5 BONUS -----------------
        public void codicePadLeft()
        {

            int decimalLength = numero.ToString("D").Length + 7;
            int hexLength = numero.ToString("X").Length + 7;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------- CODICE 8 CIFRE ---------");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------ " + numero.ToString("D" + decimalLength.ToString()) + " ------------");
            Console.WriteLine("\n");
            Console.WriteLine(".................................");
            Console.WriteLine("\n" + "\n");


        }

        //------------ METODO 4 STAMPA DATI ---------------
        public void StampaDati()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("BENVENUTI NEL NOSTRO E-COMMERCE" + "\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------- I NOSTRI PRODOTTI -------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Prodotto: " + GetNomeEsteso());
            Console.WriteLine("\n");
            Console.WriteLine("---------------------------------" + "\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------DESCRIZIONE-----------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(descrizione);
            Console.WriteLine("\n");
            Console.WriteLine("---------------------------------" + "\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------COSTI---------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Prezzo senza iva: " + prezzo);
            Console.WriteLine("Prezzo calcolato con iva: " + GetCalcolaPrezzoIva());
            Console.WriteLine("\n");

        }

        

    }
}
