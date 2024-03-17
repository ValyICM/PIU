using LibrarieModele;
using System.Collections.Generic;


namespace NivelStocareDate
{
    public class AdministrareActivitati_Memorie
    {
        private const int NR_MAX_ACTIVITATI = 100;

        private Agenda[] activitati;
        private int nrActivitati;

        public AdministrareActivitati_Memorie()
        {
            activitati = new Agenda[NR_MAX_ACTIVITATI];
            nrActivitati = 0;
        }

        public void AddActivitate (Agenda activitate)
        {
            activitate.Id = nrActivitati + 1;
            activitati[nrActivitati] = activitate;
            nrActivitati++;
        }
        
        public Agenda[] GetActivitate (out int nrActivitati)
        {
            nrActivitati = this.nrActivitati;
            return activitati;
        }

        public Agenda[] GetActivitati (string nume)
        {
            List <Agenda> activitatiGasite = new List <Agenda> ();

            foreach (Agenda activitate in activitati)
            {
                if(activitate != null && activitate.Nume == nume)
                {
                    activitatiGasite.Add(activitate);
                }
            }
            if (activitatiGasite.Count > 0)
            {
                return activitatiGasite.ToArray ();
            }
            else
            {
                return null;
            }
            
        }
    }

}
