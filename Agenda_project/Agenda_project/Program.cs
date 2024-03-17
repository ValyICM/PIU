using System;
using LibrarieModele;
using NivelStocareDate;


namespace Agenda_project
{
    class Program
    {
        static void Main()
        {
            AdministrareActivitati_Memorie adminActivitati = new AdministrareActivitati_Memorie();
            Agenda activitateNoua = new Agenda();
            int nrActivitati = 0;

            string optiune;

            do
            {
                Console.WriteLine("\n\n>>>");
                Console.WriteLine("C. Citire informatii activitate de la tastatura");
                Console.WriteLine("I. Afisarea informatiilor despre ultima activitate introdusa ");
                Console.WriteLine("A. Afisare activitati din fisier");
                Console.WriteLine("S. Salvare activitate in vector de obiecte");
                Console.WriteLine("P. Cauta activitatea dupa nume");
                Console.WriteLine("X. Inchidere program\n");
                


                Console.WriteLine("Alegeti o optiune: ");
                optiune = Console.ReadLine();

                switch(optiune.ToUpper())
                {
                    case "C":
                        activitateNoua = CitireActivitateTastatura();
                        break;

                    case "I":
                        AfisareActivitate(activitateNoua);
                        break;

                    case "A":
                        Agenda[] activitate = adminActivitati.GetActivitate(out nrActivitati);
                        AfisareActivitate(activitate, nrActivitati);
                        break;

                    case "S":
                        int idActivitate = nrActivitati + 1;
                        activitateNoua.Id = idActivitate; 
                        adminActivitati.AddActivitate(activitateNoua);

                        break;

                    case "P":
                        Console.WriteLine("Introduceti numele activitatii: ");
                        string numeActivitate = Console.ReadLine();

                        Agenda[] activitatiGasite = adminActivitati.GetActivitati(numeActivitate);
                        if (activitatiGasite != null)
                        {
                            if (activitatiGasite.Length > 0)
                            {
                                Console.WriteLine("Activitatile gasite cu numele \"" + numeActivitate + "\" sunt:");
                                // Iterăm prin vectorul de activități găsite și le afișăm
                                foreach (Agenda activitati in activitatiGasite)
                                {
                                    Console.WriteLine("Nume: " + activitati.Nume + ", Data: " + activitati.Data + ", Ora: " + activitati.Ora);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nu s-a găsit nicio activitate cu numele \"" + numeActivitate + "\".");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Eroare la obtinerea activitatilor cu numele \"" + numeActivitate + "\".");
                        }
                        break;

                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta!");
                        break;
                        
                }
            } while (optiune.ToUpper() != "X");
        }
        public static Agenda CitireActivitateTastatura()
        {
            Console.WriteLine("Introduceti numele activitaii: ");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti data desfasurarii activitatii: ");
            string data = Console.ReadLine();

            Console.WriteLine("Introduceti intervalul de ore destinat desfasurarii activitatii: [orele vor fi separate prin '->']");
            string ora = Console.ReadLine();

            Agenda activitate = new Agenda(0,nume,data,ora);

            return activitate;
        }
        public static void AfisareActivitate(Agenda activitate)
        {
            string infoActivitate = string.Format("Activitatea cu id-ul #{0} are numele: {1} \n A avut loc in data de: {2} la ora {3} ",
                    activitate.Id,
                    activitate.Nume ?? " NECUNOSCUT ",
                    activitate.Data ?? " NECUNOSCUT ",
                    activitate.Ora ?? "  NECUNOSCUT ");

            Console.WriteLine(infoActivitate);
        }

        public static void AfisareActivitate(Agenda[] activitate, int nrActivitate)
        {
            Console.WriteLine("Activitatile sunt: ");
            for(int i = 0; i < nrActivitate; i++)
            {
                string infoActivitate = activitate[i].Info();
                Console.WriteLine(infoActivitate);
            }
        }

    }
    
}