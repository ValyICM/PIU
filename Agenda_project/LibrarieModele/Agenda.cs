

using System;
using System.Web;

namespace LibrarieModele
{
    public class Agenda
    {
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

        public string Info()
        {
            Console.WriteLine("----------");
            string info = $"ID: {Id} \nNume: {Nume} \nOra: {Ora} \nData: {Data}";
            Console.WriteLine("----------");
            return info;
        }
    }
}
