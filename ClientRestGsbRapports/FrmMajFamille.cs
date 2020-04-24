using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; // pour WbClient
using mdlGsbRapports;
using Newtonsoft.Json;
using System.Collections.Specialized;

namespace ClientRestGsbRapports
{
    public partial class FrmMajFamille : Form
    {
        private string site;
        private WebClient wb;
        private Secretaire laSecretaire;
        private Famille laFamille;

        public FrmMajFamille(Secretaire s)
        {
            InitializeComponent();
            this.laSecretaire = s;
            this.wb = new WebClient();
            this.site = "http://localhost/restGSB/";
            // code ici

        }

        private void cmbFamille_SelectedIndexChanged(object sender, EventArgs e)
        {
            // code pour remplir le TextBox
        }

        private void btnMaj_Click(object sender, EventArgs e)
        {
            try
            {
                // code pour la mise à jour
            }
            catch (WebException ex)
            {
                if (ex.Response is HttpWebResponse)
                    MessageBox.Show(((HttpWebResponse)ex.Response).StatusCode.ToString());

            }
        }
    }
}
