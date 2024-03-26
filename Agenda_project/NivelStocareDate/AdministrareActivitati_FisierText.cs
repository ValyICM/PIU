using LibrarieModele;
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
        public void AddActivitate (Agenda activitati)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(activitati.ConversieLaSir_PentruFisier());
            }
        }
        public Agenda[] GetActivitati(out int nrActivitati)
        {
            Agenda[] activitati= new Agenda[NR_MAX_ACTIVITATI];

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrActivitati= 0;

                while ((linieFisier = streamReader.ReadLine()) != null) 
                {
                    activitati[nrActivitati] = new Agenda(linieFisier);
                }
            }

            return activitati;
        }
    }
}
