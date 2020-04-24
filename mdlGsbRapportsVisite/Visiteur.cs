using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlGsbRapportsVisite
{
    public class Visiteur
    {
        public string id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string ville { get; set; }
        public string adresse { get; set; }
        public string cp { get; set; }
        public DateTime dateEmbauche { get; set; }
    }
}
