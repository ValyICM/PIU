using System;


namespace LibrarieModele
{
    public class Agenda
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int NUME = 1;
        private const int DATA = 2;
        private const int ORA = 3;

        public int id;

        public int Id { get; set; }
        public string Nume { get; set; }
        public string Data { get; set; }    
        public string Ora { get; set; } 

        public Agenda() 
        { 
            Nume = string.Empty;
            Data = string.Empty;
            Ora = string.Empty;
        }

        public Agenda(int id, string nume, string data, string ora)
        {
            this.Id = id;
            this.Nume = nume;
            this.Data = data;
            this.Ora = ora;
        }

        public Agenda(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            Id = Convert.ToInt32(dateFisier[ID]);
            this.Nume = dateFisier[NUME];
            this.Data = dateFisier[DATA];
            this.Ora = dateFisier[ORA];
        }

        public string Info()
        {
            Console.WriteLine("----------");
            string info = $"ID: {Id} \nNume: {Nume} \nOra: {Ora} \nData: {Data}";
            Console.WriteLine("----------");
            return info;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectActivitatePentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                Id.ToString(),
                (Nume ?? " NECUNOSCUT "),
                (Data ?? " NECUNOSCUT "),
                (Ora ?? " NECUNOSCUT "));

            return obiectActivitatePentruFisier;

        }
    }
}
