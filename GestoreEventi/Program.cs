//MILESTONE 2//


using GestoreEventi;

Console.Write("Inserisci il nome dell'evento:");
string nome = Console.ReadLine();
Console.Write("Inserisci la data dell'evento (gg/mm/yyyy):");
string data = Console.ReadLine();
DateTime dataParse = DateTime.Parse(data);
Console.Write("Inserisci il numero di posti totali:");
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


//milestone 4

Console.WriteLine("Inserisci il nome del tuo programma Eventi:" + " ");
string nomeProgramma = Console.ReadLine();
ProgrammaEvento EventiProgrammati = new(nomeProgramma);
Console.WriteLine("Indica il numero di eventi da inserire:");
int NumeroEventi = int.Parse(Console.ReadLine());
for (int i = 0; i < NumeroEventi; i++)
{
    Console.Write("Inserisci il nome del evento:");
    string titolo = Console.ReadLine();
    Console.Write("Inserisci la data (gg / MM / yyyy) del evento:");
    data = Console.ReadLine();
    Console.Write("Inserisci il numero di posti totali:");
    capienza = int.Parse(Console.ReadLine());
    Evento evento = new(titolo, dataParse, capienza);
    EventiProgrammati.AggiungiEvento(evento);
}

Console.WriteLine(Evento);


