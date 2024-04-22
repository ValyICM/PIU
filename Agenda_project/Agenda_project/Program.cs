using System;
using LibrarieModele;
using NivelStocareDate;

namespace Agenda_project
{
    class Program
    {
        static void Main()
        {
            AdministrareActivitati_FisierText adminActivitati = new AdministrareActivitati_FisierText("D:\\Projects\\PIU-main\\Agenda_project\\Agenda_project\\numeFisier.txt");
            Agenda activitateNoua = new Agenda();
            int nrActivitati = 0;

            string optiune;

            do
            {
                Console.WriteLine("\n\n>>>");
                Console.WriteLine("C. Citire informatii activitate de la tastatura");
                Console.WriteLine("I. Afisarea informatiilor despre ultima activitate introdusa ");
                Console.WriteLine("A. Afisare activitati din fisier");
                Console.WriteLine("S. Salvare activitate in fisier");
                Console.WriteLine("N. Cautare activitati dupa nume");
                Console.WriteLine("K. Cautare activitati dupa ID");
                Console.WriteLine("D. Cautare activitati dupa data");
                Console.WriteLine("X. Inchidere program\n");

                Console.WriteLine("Alegeti o optiune: ");
                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "C":
                        activitateNoua = CitireActivitateTastatura();
                        break;

                    case "I":
                        AfisareActivitate(activitateNoua);
                        break;

                    case "A":
                        Agenda[] activitate = adminActivitati.GetActivitati(out nrActivitati);
                        AfisareActivitate(activitate, nrActivitati);
                        break;

                    case "S":
                        int idActivitate = ++nrActivitati;
                        activitateNoua.Id = idActivitate;
                        adminActivitati.AddActivitate(activitateNoua);
                        break;

                    case "N":
                        Console.WriteLine("Introduceti numele pentru cautare:");
                        string numeCautare = Console.ReadLine();
                        adminActivitati.CautaActivitatiDupaCriteriu("nume", numeCautare);
                        break;

                    case "K":
                        Console.WriteLine("Introduceti ID-ul pentru cautare:");
                        string idCautare = Console.ReadLine();
                        adminActivitati.CautaActivitatiDupaCriteriu("id", idCautare);
                        break;

                    case "D":
                        Console.WriteLine("Introduceti data pentru cautare:");
                        string dataCautare = Console.ReadLine();
                        adminActivitati.CautaActivitatiDupaCriteriu("data", dataCautare);
                        break;

                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta!");
                        break;

                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }
        public static Agenda CitireActivitateTastatura()
        {
            Console.WriteLine("Introduceti numele activitaii: ");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti data desfasurarii activitatii: ");
            string data = Console.ReadLine();

            Console.WriteLine("Introduceti intervalul de ore destinat desfasurarii activitatii: [orele vor fi separate prin '->']");
            string ora = Console.ReadLine();

            Agenda activitate = new Agenda(0, nume, data, ora);

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
            for (int i = 0; i < nrActivitate; i++)
            {
                string infoActivitate = activitate[i].Info();
                Console.WriteLine(infoActivitate);
            }
        }
    }
}
