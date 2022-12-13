﻿namespace GestoreEventi
{
    internal class Evento
    {
        //Attributi
        private string titolo;
        private DateTime data;
        private int capienzaMassima;
        private int numeroPostiPrenotati = 0;

        //Stato
        //Getter
        public string getTitolo()
        {
            return titolo;
        }

        public DateTime getData()
        {
            return data;
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
                throw new Exception();
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
            this.numeroPostiPrenotati = numeroPostiPrenotati;
        }


        //Costruttori

        public Evento(string titolo, DateTime data, int capienzaMassima, int numeroPostiPrenotati)
        {

            this.setTitolo(titolo);
            this.setData(data);
            this.capienzaMassima = capienzaMassima;
            this.numeroPostiPrenotati = numeroPostiPrenotati;
        }










        //Metodi public

        public int PrenotaPosti(int posti)
        {
            DateTime dataFlag = DateTime.Now;
            if (posti < this.capienzaMassima)
            {
                int nuoviPostiPrenotati = posti + this.numeroPostiPrenotati;
            } else if (this.data < dataFlag)
            {
                throw new Exception();
            }

            return nuoviPostiPrenotati;


        }

        /*
        public int DisdiciPosti()
        {
            return
        }

        public override string ToString()
        {
            return base.ToString();
        }

        //Metodi privati
        */
    }
}