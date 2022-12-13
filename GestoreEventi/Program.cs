//MILESTONE 2//


using GestoreEventi;

Console.Write("Inserisci il nome dell'evento:");
string nome = Console.ReadLine();
Console.Write("Inserisci la data dell'evento (gg/mm/yyyy):");
string data = Console.ReadLine();
DateTime dataParse = DateTime.Parse(data);
Console.Write("Inserisci il numero di posti totali:");
int capienza = Console.Read();
Console.Write("Quanti posti desideri prenotare?");
int numeroPrenotazioni = Console.Read();





/*
Evento eventoUno = new Evento(nome, dataParse, capienza, numeroPrenotazioni);
eventoUno.ToString();
*/