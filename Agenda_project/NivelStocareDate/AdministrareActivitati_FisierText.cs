using LibrarieModele;
using System;
using System.IO;


namespace NivelStocareDate
{
    public class AdministrareActivitati_FisierText
    {
        private const int NR_MAX_ACTIVITATI = 100;
        private string numeFisier;

        public AdministrareActivitati_FisierText(string numeFisier) 
        { 
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public int ID { get; private set; }

        public void AddActivitate (Agenda activitati)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(activitati.ConversieLaSir_PentruFisier());
            }
        }
        public Agenda[] GetActivitati(out int nrActivitati)
        {
            Agenda[] activitati = new Agenda[NR_MAX_ACTIVITATI];
            nrActivitati = 0;

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    activitati[nrActivitati] = new Agenda(linieFisier);
                    nrActivitati++;

                    if (nrActivitati >= NR_MAX_ACTIVITATI)
                    {
                        Array.Resize(ref activitati, activitati.Length * 2);
                    }
                }
            }

            Array.Resize(ref activitati, nrActivitati);
            return activitati;
        }

        public void CautaActivitatiDupaCriteriu(string criteriu, string valoare)
        {
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Agenda activitate = new Agenda(linieFisier);

                    switch (criteriu.ToLower())
                    {
                        case "nume":
                            if (activitate.Nume.ToLower() == valoare.ToLower())
                            {
                                Console.WriteLine(activitate.Info());
                            }
                            break;
                        case "id":
                            if (activitate.Id.ToString() == valoare)
                            {
                                Console.WriteLine(activitate.Info());
                            }
                            break;
                        case "data":
                            if (activitate.Data.ToLower() == valoare.ToLower())
                            {
                                Console.WriteLine(activitate.Info());
                            }
                            break;
                        default:
                            Console.WriteLine("Criteriul specificat nu este valid.");
                            break;
                    }
                }
            }
        }
    }
}
