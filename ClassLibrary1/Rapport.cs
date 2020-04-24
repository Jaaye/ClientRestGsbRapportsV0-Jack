using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlGsbRapports
{
    public class Rapport
    {
       
        public string motif { get;}
        public string bilan { get; }
        public DateTime date { get; }
        //public int idMedecin { get;}
        //public string idVisiteur { get; }
        //public List<Medicament> medicaments { get; set; }
        public string nomVisiteur { get; }
        public string prenomVisiteur { get; }
        public string nomMedecin { get; }
        public string prenomMedecin { get; }
        public Rapport(string motif, string bilan, DateTime date, string nomVisiteur, string prenomVisiteur,string nomMedecin, string prenomMedecin)
        {
            this.motif = motif;
            this.bilan = bilan;
            this.date = date;
            this.nomMedecin = nomMedecin;
            this.prenomMedecin = prenomMedecin;
            this.prenomVisiteur = prenomVisiteur;
            this.nomVisiteur = nomVisiteur;
        }

    }
}
