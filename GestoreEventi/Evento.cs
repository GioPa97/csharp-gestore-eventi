namespace GestoreEventi
{
    internal class Evento
    {
        //Attributi
        private string titolo;
        private DateTime data;
        private int capienzaMassima;
        private int numeroPostiPrenotati;

        //Stato
        //Getter
        public string getTitolo()
        {
            return titolo;
        }

        public DateTime getData()
        {
            return this.data;
        }

        public int getCapienzaMassima()
        {
            return capienzaMassima;
        }

        public int getNumeroPostiPrenotati()
        {
            return numeroPostiPrenotati;
        }

        //Setter

        public void setTitolo(string titolo)
        {
            titolo.ToLower();
            if (titolo != null)
            {
                this.titolo = titolo;
            }
            else
            {
                throw new Exception();
            }
        }

        public void setData(DateTime data)
        {

            DateTime dataFlag = DateTime.Now;

            if (data > dataFlag)
            {
                this.data = data;
            }
            else
            {
                throw new Exception("La data inserita non è valida!");
            }

        }

        private void setCapienzaMassima(int capienzaMassima)
        {
            if (capienzaMassima > 0)
            {
                this.capienzaMassima = capienzaMassima;
            }
            else
            {
                throw new Exception();
            }
        }

        private void setNumeroPostiPrenotati(int numeroPostiPrenotati)
        {
            if (numeroPostiPrenotati > 0)
            {
                this.numeroPostiPrenotati = numeroPostiPrenotati;
            }
            else
            {
                throw new Exception();
            }
        }


        //Costruttori

        public Evento(string titolo, DateTime data, int capienzaMassima)
        {

            setTitolo(titolo);
            setData(data);
            this.capienzaMassima = capienzaMassima;
            numeroPostiPrenotati = 0;

        }










        //Metodi publici
        public int PrenotaPosti(int numeroPostiDaPrenotare)
        {
            DateTime dataFlag = DateTime.Now;
            if (numeroPostiDaPrenotare <= this.capienzaMassima)
            {
                this.numeroPostiPrenotati = numeroPostiDaPrenotare + this.numeroPostiPrenotati;
            }
            else if (this.data < dataFlag)
            {
                throw new Exception();
            }
            else if (numeroPostiDaPrenotare > this.capienzaMassima)
            {
                throw new Exception();
            }
            Console.WriteLine("Numero di posti prenotati=" + " " + this.numeroPostiPrenotati);
            Console.WriteLine("Numero di posti disponibili=" + " " + (capienzaMassima - this.numeroPostiPrenotati));

            return numeroPostiDaPrenotare;


        }



        public int DisdiciPosti(int numeroPostiDaDisdire)
        {


            DateTime dataFlag = DateTime.Now;
            if (numeroPostiDaDisdire <= this.numeroPostiPrenotati)
            {
                this.numeroPostiPrenotati = this.numeroPostiPrenotati - numeroPostiDaDisdire;
            }
            else if (this.data < dataFlag)
            {
                throw new Exception();
            }
            else if (numeroPostiDaDisdire > this.numeroPostiPrenotati)
            {
                throw new Exception("Non puoi disdire più posti di quanti ne sono prenotati!");
            }
            else if (numeroPostiDaDisdire > this.capienzaMassima)
            {
                throw new Exception("Non puoi disdire più posti di quanti ce ne sono disponibili!");
            }


            Console.WriteLine("Numero di posti prenotati=" + " " + this.numeroPostiPrenotati);
            Console.WriteLine("Numero di posti disponibili=" + " " + (capienzaMassima - this.numeroPostiPrenotati));
            Console.WriteLine();
            return numeroPostiDaDisdire;
        }
        public override string ToString()
        {
            string stampaEvento = getData() + " - " + getTitolo();
            return stampaEvento;
        }
    }
}
