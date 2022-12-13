//MILESTONE 2//


using GestoreEventi;

Console.Write("Inserisci il nome dell'evento:" +" ");
string nome = Console.ReadLine();
Console.Write("Inserisci la data dell'evento (gg/mm/yyyy):" + " ");
string data = Console.ReadLine();
DateTime dataParse = DateTime.ParseExact(data, "dd/MM/yyyy", null);
Console.Write("Inserisci il numero di posti totali:" + " ");
int capienza = int.Parse(Console.ReadLine());
Console.WriteLine();

Evento eventoUno = new Evento(nome, dataParse, capienza);

Console.Write("Quanti posti desideri prenotare?");
int numeroPrenotazioni = int.Parse(Console.ReadLine());
int prenotazioni = eventoUno.PrenotaPosti(numeroPrenotazioni);

string flag = "";

do
{
    Console.Write("Vuoi disdire dei posti (si/no)");
    flag = Console.ReadLine();
    if (flag.ToLower() == "si")
    {
        Console.Write("Indica il numero di posti da disdire:");
        int disdetta = int.Parse(Console.ReadLine());
        eventoUno.DisdiciPosti(disdetta);
    }
}
while (flag.ToLower() != "no");
Console.WriteLine("Ok va bene!");
Console.WriteLine();

eventoUno.ToString();

//milestone 4

Console.Write("Inserisci il nome del tuo programma Eventi:" + " ");
string nomeProgramma = Console.ReadLine();
ProgrammaEventi EventiProgrammati = new(nomeProgramma);
Console.Write("Indica il numero di eventi da inserire:");
int NumeroEventi = int.Parse(Console.ReadLine());
Console.WriteLine();
for (int i = 0; i < NumeroEventi; i++)
{
    int ordine = i + 1;
    Console.Write("Inserisci il nome del" + " " +ordine+"°" +" " + "evento:" +" ");
    string titolo = Console.ReadLine();
    Console.Write("Inserisci la data (gg / MM / yyyy) del evento:" +" ");
    data = Console.ReadLine();
    dataParse = DateTime.ParseExact(data, "dd/MM/yyyy", null);
    Console.Write("Inserisci il numero di posti totali:" + " ");
    capienza = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Evento evento = new(titolo, dataParse, capienza);
    EventiProgrammati.AggiungiEvento(evento);
}

EventiProgrammati.GetEventi();



