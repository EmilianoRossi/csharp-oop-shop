//------------ creo l'oggetto ------------


using BONUS;

Class1 mioProdotto = new Class1("AirPods", "Cuffie wireless", 129.90, "22%");

mioProdotto.GetGeneraCodiceProdotto();
mioProdotto.GetCalcolaPrezzoIva();
mioProdotto.GetNomeEsteso();
mioProdotto.StampaDati();
mioProdotto.codicePadLeft();

//----------- creo un altro oggetto ---------

Class1 mioProdotto2 = new Class1("Beats Studio", "Cuffie con padiglione e con cavo", 250.90, "22%");
mioProdotto2.GetGeneraCodiceProdotto();
mioProdotto2.GetCalcolaPrezzoIva();
mioProdotto2.GetNomeEsteso();
mioProdotto2.StampaDati();
mioProdotto2.codicePadLeft();


