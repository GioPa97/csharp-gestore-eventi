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
    if (flag == "si")
    {
        Console.Write("Indica il numero di posti da disdire:");
        int disdetta = int.Parse(Console.ReadLine());
        eventoUno.DisdiciPosti(disdetta);
    }
}
while (flag != "no");
{
    Console.WriteLine("Ok va bene!");
    Console.WriteLine();
}



