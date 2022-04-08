using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop
{
    //----------- CLASSE PRODOTTO ---------------
    internal class Prodotto
    {

    //---------- DICHIARO LE VARIABILI --------------
        private int codiceProdotto;
        private string nomeProdotto;
        private string descrizione;
        private float prezzo;
        private float iva;

    //---------- COSTRUTTORE --------------
    public Prodotto (string nomeProdotto , string descrizione , float prezzo , float iva)
        {

            this.nomeProdotto = nomeProdotto;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;

        }

        //-------------- METODO 1 CREAZIONE CODICE -------------

        public int generaCodiceProdotto()
        {

            Random random = new Random();
            int numero = random.Next(100);
            return numero;


        }

        public void stampa()
        {
            Console.WriteLine(generaCodiceProdotto());
        }

        

    }
}
