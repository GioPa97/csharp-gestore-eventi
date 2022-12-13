using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class ProgrammaEvento
    {
        //Attributi
        string titolo;
        List<Evento> eventi;
        //Costruttori
        public ProgrammaEvento(string titolo)
        {
            this.titolo = titolo;
            eventi = new List<Evento>();

        }
        //Metodi
        public void AggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }
        //Metodo statico--------------------------------------------
        public static void GetListaEvento(List<Evento> lista)
        {
            foreach (var evento in lista)
            {
                Console.WriteLine(evento);
            }
            Console.WriteLine();
        }
        //-----------------------------------------------------------
        public int ContatoreEventi()
        {
            return eventi.Count;
        }
        public void SvuotaLista()
        {
            eventi.Clear();
        }
        public void GetEventi()
        {
            Console.WriteLine(titolo + ":");
            for (int i = 0; i < ContatoreEventi(); i++)
            {
                int indice = i + 1;
                Console.WriteLine(indice + "° Evento" + eventi[i]);

            }
        }












    }
}
