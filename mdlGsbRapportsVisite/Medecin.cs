using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlGsbRapportsVisite
{
    public class Medecin
    {
        public int id { get; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adresse { get; set; }
        public string tel { get; set; }
        public string specialiteComplementaire { get; set; }
        public Medecin(int id, string nom, string prenom, string adresse, string telephone, string specialite)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.tel = telephone;
            this.specialiteComplementaire = specialite;

        }
            
    }
}
