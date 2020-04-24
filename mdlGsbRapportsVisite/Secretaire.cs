using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;     // pour SHA1


namespace mdlGsbRapportsVisite
{
    public class Secretaire
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string ticket { get; set; }
        public string mdp { get; set; }
        public Secretaire(string nom, string prenom, string ticket, string mdp)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.ticket = ticket;
            this.mdp = mdp;
        }
        public string hashTicketMdp()
        {
            string h = "";
            
            return h;
        }
    }
}
