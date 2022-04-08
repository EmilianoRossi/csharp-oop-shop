//------------ creo l'oggetto ------------
using CsharpShop;

Prodotto mioProdotto = new Prodotto("AirPods" , "Cuffie wireless" , 129.90 , "22%");

mioProdotto.GetGeneraCodiceProdotto();
mioProdotto.GetCalcolaPrezzoIva();
mioProdotto.GetNomeEsteso();
mioProdotto.StampaDati();

//----------- creo un altro oggetto ---------

Prodotto mioProdotto2 = new Prodotto("Beats Studio", "Cuffie con padiglione e con cavo", 250.90, "22%");
mioProdotto2.GetGeneraCodiceProdotto();
mioProdotto2.GetCalcolaPrezzoIva();
mioProdotto2.GetNomeEsteso();
mioProdotto2.StampaDati();


