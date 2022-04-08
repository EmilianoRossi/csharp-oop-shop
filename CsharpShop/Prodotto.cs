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
        private double prezzo;
        private string iva;

    //---------- COSTRUTTORE --------------
    public Prodotto (string nomeProdotto , string descrizione , double prezzo , string iva)
        {

            this.nomeProdotto = nomeProdotto;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;

        }

        //-------------- METODO 1 CREAZIONE CODICE -------------

        public int GeneraCodiceProdotto()
        {

            Random random = new Random();
            int numero = random.Next(100);
            return numero;


        }

        //------------ METODO 2 CALCOLA PREZZO CON IVA ------------

        public double CalcolaPrezzoIva() 
        {

            double prezzoConIva = prezzo * 0.22;
            return prezzoConIva;

        }

        //----------- METODO 3 STAMPA NOME ESTESO ----------
        public string NomeEsteso()
        {

            string nomePiuCodice = nomeProdotto + " " + GeneraCodiceProdotto();
            return nomePiuCodice;

        }

    }
}
